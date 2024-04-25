using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject CameraYspeed;
    public float offset;
    public float offsetSmooth;
    private Vector3 playerpostion;
    public GameObject a;
   
     

    // Start is called before the first frame update
    void Start()
    {
        playerpostion = a.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerpostion = new Vector2(transform.position.y, transform.position.x);

        if(transform.position.y < a.transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, a.transform.position.y, transform.position.z);
        }

    }
}
