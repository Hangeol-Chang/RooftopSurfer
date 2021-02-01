using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerBehaviour : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = player.transform.position;
        Pos.y = (player.transform.position.y + 1.2f) / 2;
        this.transform.position = new Vector3(Pos.x + 6.5f, Pos.y,-10);
    }
}
