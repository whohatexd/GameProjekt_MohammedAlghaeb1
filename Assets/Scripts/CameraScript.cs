using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CameraScript : MonoBehaviour
{
   
    private Vector3 playerpostion;
    private Vector3 deathPLatPostion;
    public GameObject player;
    public GameObject DeathPlatform;
    LoadGame Gotoscene;
   
     

    // Start is called before the first frame update
    void Start()
    {
        playerpostion = player.transform.position;
        deathPLatPostion = DeathPlatform.transform.position;
        
        Gotoscene = GetComponentInChildren<LoadGame>();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerpostion = new Vector2(transform.position.y, transform.position.x);
        transform.position += new Vector3(0, 1*Time.deltaTime, 0);

        if (transform.position.y < player.transform.position.y)
        {
            transform.position += new Vector3(0, player.transform.position.y - transform.position.y, 0);
        }
        else if (playerpostion.y == 15)
        {
            transform.position += new Vector3(0, 5 * Time.deltaTime, 0);
        }

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bat")
        {
            Gotoscene = GetComponentInChildren<LoadGame>();
            
            
        }
    }
}
