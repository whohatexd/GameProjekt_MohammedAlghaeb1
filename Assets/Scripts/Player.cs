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
    Animation Anime;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Anime = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(movspeed, rb.velocity.y);

        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(movspeed * -1, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpStenghte));
        }

        if (rb.velocity.x == 0)
        {
            Anime.Play("Anime.idle");
        }
        
    }
}
