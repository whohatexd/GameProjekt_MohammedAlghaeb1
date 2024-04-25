using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
   
    private Vector3 playerpostion;
    public GameObject player;
    LoadGame Gotoscene;
   
     

    // Start is called before the first frame update
    void Start()
    {
        playerpostion = player.transform.position;
        Gotoscene = GetComponentInChildren<LoadGame>();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerpostion = new Vector2(transform.position.y, transform.position.x);

        if(transform.position.y < player.transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        }

        if (transform.position.y > player.transform.position.y)
        {
            Gotoscene.GOtoScene("Main Menu");
        }

    }
}
