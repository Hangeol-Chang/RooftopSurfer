using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSummoner : MonoBehaviour
{
    public GameObject[] buildingprefabs = new GameObject[20];
    private bool cansummon = true;

    private int buildingnum = 0;

    private Vector3 summonPos;
    private float lastxlength = 15.7f;
    private float lastyheight = -2.2f;
    IEnumerator summonbuilding()
    {
        do
        {
            buildingnum = Random.Range(0, 7);
        } while (buildingprefabs[buildingnum].activeSelf == true);

        cansummon = false;

        summonPos = new Vector3(lastxlength + (buildingprefabs[buildingnum].GetComponent<BuildingBehaviour>().xlen / 2), 
                                lastyheight + Random.Range(-1f, 1.5f) - buildingprefabs[buildingnum].GetComponent<BuildingBehaviour>().sillingy, 0);

        //if (summonPos.y < -4.5f) summonPos.y = -4.5f;
        //else if(summonPos.y > 1.5f) summonPos.y = 1.5f;
        buildingprefabs[buildingnum].transform.position = summonPos;
        buildingprefabs[buildingnum].gameObject.SetActive(true);

        lastxlength = 11 + (buildingprefabs[buildingnum].GetComponent<BuildingBehaviour>().xlen / 2);
        lastyheight = buildingprefabs[buildingnum].transform.position.y + buildingprefabs[buildingnum].GetComponent<BuildingBehaviour>().sillingy;

        yield return new WaitForSeconds(0.1f);
        cansummon = true;
    }
    void Start()
    {
        buildingnum = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (buildingprefabs[buildingnum].transform.position.x < 10 && cansummon == true)  StartCoroutine( summonbuilding());
    }
}
