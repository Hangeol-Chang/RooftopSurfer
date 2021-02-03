using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hookbehaviour : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Contains("pillar"))
        {
            GetComponentInParent<Hookcontroller>().movetype = 4;
        }
    }
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
        }else if (GetComponentInParent<Hookcontroller>().movetype == 2)
        {
            this.transform.Translate(0, 0, 0);
        }else if (GetComponentInParent<Hookcontroller>().movetype == 3)
        {

        }
    }
}
