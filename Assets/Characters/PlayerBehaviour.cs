using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    private bool canjump = true;
    private bool canrope = false;
    private Rigidbody2D rigid;
    private Animator ani;

    public GameObject Hook;
    //public GameObject[] rope = new GameObject[10];

    private float jumpforce = 500f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("map"))
        {
            canjump = true;
            ani.SetBool("jump", false);
        }
    }
    void jump()
    {
        canjump = false;
        canrope = true;
        ani.SetBool("jump", true);
        this.rigid.AddForce(Vector2.up * jumpforce);
    }
    void ropeshoot()
    {
        Hook.SetActive(true);
    }
    void ropecatch()
    {
        ani.SetBool("rope", true);
    }
    void Start()
    {
        this.rigid = GetComponent<Rigidbody2D>();
        this.ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canjump == true) jump();
            else if (canrope == true) ropeshoot();
        }
        if (this.rigid.velocity.y != 0) canjump = false;
        if (this.transform.position.y < -4.5f) SceneManager.LoadScene("GameScene");
    }
}
