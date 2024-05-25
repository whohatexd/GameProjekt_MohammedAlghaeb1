using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private float fallingDelay = 0.8f;
    private float destroyDelay = 4f;

    [SerializeField] private Rigidbody2D rb;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            StartCoroutine(Fall());
        }
    }
    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallingDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, fallingDelay);
    }
}
