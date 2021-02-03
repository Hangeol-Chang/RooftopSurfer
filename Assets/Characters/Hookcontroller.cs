using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hookcontroller : MonoBehaviour
{
    public GameObject[] rope = new GameObject[6];
    private int ropenum = 0;
    public int movetype = 0; //0=안움직임, 1=날라감, 2=날라감 대기상태, 3= 돌아옴, 4=멈춤
    private float distance = 1;

    void Start()
    {
        Debug.Log(movetype);
    }

    void Update()
    {
        if (movetype == 1)
        {

            rope[0].SetActive(true);

            if (Vector3.Distance(this.gameObject.transform.position, rope[ropenum].transform.position) > distance)
            {
                if (ropenum < 5)
                {
                    ropenum += 1;
                    rope[ropenum].SetActive(true);
                }
                else
                {
                    movetype = 2;
                    StartCoroutine(Hookstay());
                }
            }
            else if (movetype == 3)
            {
                if (ropenum == 0)
                {
                    rope[ropenum].SetActive(false);
                }else if (Vector3.Distance(this.gameObject.transform.position, rope[ropenum].transform.position) > distance && ropenum>0)
                {
                    rope[ropenum].SetActive(false);
                    ropenum -= 1;
                }
            }
        }
    }
        IEnumerator Hookstay()
        {
            yield return new WaitForSeconds(0.2f);
            movetype = 3;
        }
}
