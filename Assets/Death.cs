using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour
    
{
    // Start is called before the first frame update
    public string nextLevel = "";
   
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(nextLevel);

        }
    }
}
