using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala1Controller : MonoBehaviour
{
    public float velocityX = 0.5f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(velocityX , rb.velocity.y);
        transform.Translate(new Vector2(velocityX * 15, velocityX * 3) * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("trigger");
        Debug.Log(other.gameObject.name);
        Destroy(this.gameObject);
    }
}
