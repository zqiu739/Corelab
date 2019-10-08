using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookieMove : MonoBehaviour
{
    float horz;
    public float speed;
    Rigidbody2D rb;
    bool canJump;
    int numJumpAllowed;
    int jumpnumber;

    // Start is called before the first frame update
    void Start()
    {
        horz = Input.GetAxis("Horizontal");
        speed = 3;
        rb = GetComponent<Rigidbody2D>();
        canJump = true;
        numJumpAllowed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horz * speed * Time.deltaTime);

        if (canJump)
        {
            if (jumpnumber < numJumpAllowed)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
                    jumpnumber++;
                }
            }
            else
            {
                canJump = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "round")
        {
            canJump = true;
            jumpnumber = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "upgrade")
        {
            numJumpAllowed = 2;
            Destroy(collision.gameObject);
        }
    }
}
