using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBehaviour : MonoBehaviour
{
    public float movespeed = 0.01f;
    public float xlen;
    public float sillingy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < -15) gameObject.SetActive(false);
        transform.Translate(Vector3.left * movespeed);
    }
}
