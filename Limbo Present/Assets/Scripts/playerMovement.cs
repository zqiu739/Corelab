using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    bool jumpdis;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = .1f;
        jumpdis = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        if (Input.GetKeyDown(KeyCode.W) && (jumpdis == true))
        {
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            jumpdis = false;
            rb.gravityScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && (jumpdis == true))
        {
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            jumpdis = false;
            rb.gravityScale = 1;
        }
        transform.position += Movement * speed;
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
        if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }

        if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            jumpdis = true;
            rb.gravityScale = 1;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ladder")
        {
            jumpdis = true;
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
            {
                rb.constraints = RigidbodyConstraints2D.None;
                transform.Translate(new Vector2(0, .5f) * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
            {
                rb.constraints = RigidbodyConstraints2D.None;
                transform.Translate(new Vector2(0, -.5f) * Time.deltaTime);
            }
        }
    }
}

