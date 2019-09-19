using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle_physics : MonoBehaviour
{
    float forceamount;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        forceamount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject)
        {
            rb.AddForce(new Vector2(0, 1) * forceamount, ForceMode2D.Impulse);
        }
    }
}
