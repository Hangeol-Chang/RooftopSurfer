using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hookbehaviour : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnEnable()
    {
        this.transform.position = transform.parent.gameObject.transform.position + new Vector3(0.05f, 0f, 0f);
    }

    void Update()
    {
        if (GetComponentInParent<Hookcontroller>().movetype == 1)
        {
            this.transform.Translate(0.01f, 0.01f, 0);
        }else if (GetComponentInParent<Hookcontroller>().movetype == 1)
        {

        }
    }
}
