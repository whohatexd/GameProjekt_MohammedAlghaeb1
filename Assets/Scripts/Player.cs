using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float movspeed;
    float speedX;
    Rigidbody2D rb;
    public float jumpStenghte = 4;
    Animator Anime;
    groundCheck groundcheck;
    LoadGame SceneSwitch;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Anime = GetComponent<Animator>();
        groundcheck = GetComponentInChildren<groundCheck>();
        SceneSwitch = GetComponentInChildren<LoadGame>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(movspeed, rb.velocity.y);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-movspeed, rb.velocity.y);
        }
        if ((Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.Space)) && groundcheck.IsGrounded) 
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpStenghte);
        }
        if (transform.position.y < -7)
        {
            //
        }







        anime();

    }

    void anime()
    {
        if (rb.velocity.y > 0)
        {
            Anime.Play("Anime_Hopp");
        }
        else if (rb.velocity.y < 0)
        {
            Anime.Play("Anime_Fall");
        }

        else if (rb.velocity.x > 0)
        {
            Anime.Play("Anime_Move_D");
        }

        else if(rb.velocity.x == 0 && rb.velocity.y == 0)
        {
            Anime.Play("Anime_Idle");
        }
        else if (rb.velocity.x < 0)
        {
            Anime.Play("Anime_Move_A");
        }

        
    }
    
}
