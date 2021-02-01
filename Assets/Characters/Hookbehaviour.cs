using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hookbehaviour : MonoBehaviour
{
    public GameObject[] rope = new GameObject[10];
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        this.transform.position = transform.parent.gameObject.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(1f, 1f, 0);
    }
}
