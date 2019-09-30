using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chargeBehavior : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 3)
        {
            rb.gravityScale = 0.1f;
            rb.drag = 1.5f;
        }

        if (transform.position.y <= -4)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "American Sub_0")
        {
            Destroy(this.gameObject);
            Instantiate(explosion, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
        }
    }
}
