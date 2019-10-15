using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleBehavior : MonoBehaviour
{
    Rigidbody2D rb;
    float gravity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gravity = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 7.09f)
        {
            transform.position = new Vector2(7.089f, transform.position.y);
        }

        if (transform.position.x <= -7.09f)
        {
            transform.position = new Vector2(-7.089f, transform.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            rb.gravityScale = gravity *-1;
            
        }
    }
}
