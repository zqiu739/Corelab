using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boxMove : MonoBehaviour
{
    public static boxMove boxPreserve;

    private void Awake()
    {
        if (boxPreserve == null)
        {
            boxPreserve = this;
            DontDestroyOnLoad(this);
        }
        else if (boxPreserve != this)
        {
            Destroy(gameObject);
        }
    }

    float speed;
    Rigidbody2D rb;
    bool jumpdis;
    int sceneNo;
    float gravity;

    // Start is called before the first frame update
    void Start()
    {
        speed = .1f;
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(0, 0);
        sceneNo = 1;
        gravity = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        if (Input.GetKeyDown(KeyCode.W) && (jumpdis==true))
        {
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            jumpdis = false;
        }
        if (gravity >= 1)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && (jumpdis == true))
            {
                rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
                jumpdis = false;
            }
        }

        transform.position += Movement * speed;

        if (transform.position.x >= 7.09f)
        {
            transform.position = new Vector2(7.089f, transform.position.y);
        }

        if (transform.position.x <= -7.09f)
        {
            transform.position = new Vector2(-7.089f, transform.position.y);
        }

        if (gravity <= 0)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) && (jumpdis == true))
            {
                rb.AddForce(new Vector2(0, -5), ForceMode2D.Impulse);
                jumpdis = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpdis = true;
        if (collision.gameObject.tag == "nextScene")
        {
            SceneManager.LoadScene(sceneNo);
            sceneNo += 1;
            textManager.Continue.texty();
            transform.position = new Vector3(0, 0, 0);
        }
        if (collision.gameObject.tag == "flipper")
        {
            gravity = gravity * -1;
            rb.gravityScale = gravity;
            Destroy(collision.gameObject);
        }
    }
}
