using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject balaP;
    public GameObject balaP1;
    public GameObject balaP2;
    public float fuerzaDisparo = 5f;
    private Rigidbody2D rb;
    private Rigidbody2D rb1;
    private Rigidbody2D rb2;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       if(Input.GetKeyUp(KeyCode.U)) 
        {
          Disparar();
    }
         // crear a la bala
         // que objeto
         // en donde debe aparecer
         // que rotacion va a tener?
       /*  var currentPosition = transform.position;
         var position = new Vector3(currentPosition.x - 5, currentPosition.y, 10);
         var balaGO = Instantiate(bala, position, Quaternion.identity);
         var controller = balaGO.GetComponent<BalaController>();
         controller.velocityX = -1f;
       }*/
       }
       void Disparar()
        {
            Vector3 direccion = transform.localScale.x > 0 ? Vector3.right : Vector3.left;
            GameObject bala = Instantiate(balaP, transform.position + direccion * 0.5f, Quaternion.identity);
            GameObject bala1 = Instantiate(balaP1, transform.position + direccion * 0.5f, Quaternion.identity);
             GameObject bala2 = Instantiate(balaP2, transform.position + direccion * 0.5f, Quaternion.identity);
            Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
            Rigidbody2D rb1 = bala1.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = bala2.GetComponent<Rigidbody2D>();
            rb.AddForce(direccion * fuerzaDisparo, ForceMode2D.Impulse);
        }

    
}
