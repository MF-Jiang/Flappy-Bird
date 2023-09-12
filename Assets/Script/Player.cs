using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D rb;

    public static bool life = true;
    private Animator anim;

    private GameObject gameover;

    private float time;

    private AudioSource asource;
    public AudioClip crashClip;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        asource = GetComponent<AudioSource>();
        gameover = GameObject.Find("Canvas/Over");
    }

    // Update is called once per frame
    void Update()
    {
        if(life)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                asource.Play();
            }
        }
        else
        {
            time += Time.deltaTime;

            if (time > 3)
            {
                Fadeinandout.changeScene("title");
            }
        }

        gameover.SetActive(!life);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (life)
        {
            Flash.flash();
            asource.clip = crashClip;
            asource.Play();
        }
        life = false;
        anim.SetBool("life", false);
    }
}
