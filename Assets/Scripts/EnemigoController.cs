using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoController : MonoBehaviour
{
    public int vida = 1;
    public GameObject bala;
    //public GameObject explosionPrefab;

    public float xVelocity = 1f;    
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        var yVelocity = rb.velocity.y;
        
        rb.velocity = new Vector2(-xVelocity, yVelocity);

       if (vida <= 0)
        {
            Destroy(gameObject);
        }

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bala"))
        {
            vida--;
            Destroy(other.gameObject);
        }
    }

 
   /* void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Enemigo")) {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }*/

    




}
