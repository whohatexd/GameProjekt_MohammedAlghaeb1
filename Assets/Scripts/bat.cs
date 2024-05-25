using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class bat : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    public Vector2 velocity;
    Animator Anime;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = velocity;
        Anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "batTrigger")
        {
            rb2d.velocity *= -1;
            Anime.Play("Anime_BatD");
            
        }
    }

}
