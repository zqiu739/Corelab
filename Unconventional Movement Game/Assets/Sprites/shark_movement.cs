using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shark_movement : MonoBehaviour
{
    //float horz;
    //float vert;
    Rigidbody2D rb;
    SpriteRenderer fl;
    public float forceamount;
    float size;
    float grow;
    public GameObject fish;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, 5);
        fl = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        forceamount = 3;
        size = 3;
        grow = .1f;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

        if (Input.GetKey("space"))
        {
            Vector2 direction = (mousePos - transform.position);
            rb.AddForce(new Vector2(direction.x, direction.y) * forceamount);
        }

        if (mousePos.x < transform.position.x) {
            fl.flipX = true;
        }

        if (mousePos.x > transform.position.x)
        {
            fl.flipX = false;
        }

        if (transform.position.y > 3)
        {
            rb.gravityScale = 1;
            rb.drag = 0;
            forceamount = 0;
        }

        if (transform.position.y < 2.99f)
        {
            rb.gravityScale = 0;
            rb.drag = 2;
            forceamount = 3;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fish")
        {
            grow = grow + .1f;
            Destroy(collision.gameObject);
            transform.localScale = new Vector2(size + grow, size + grow);
        }
    }
}