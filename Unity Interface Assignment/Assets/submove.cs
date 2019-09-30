using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submove : MonoBehaviour
{
    //float timer;
    float speed;
    float lives;
    //public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        lives = 5;
        speed = .05f;
        //timer = 0;
        transform.position = new Vector2(-4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            Destroy(this.gameObject);
        }
        //timer += Time.deltaTime;
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += Movement * speed;

        if (transform.position.y >= 2.5f)
        {
            transform.position = new Vector2(transform.position.x, 2.49f);
        }

        if (transform.position.y <= -4.3f)
        {
            transform.position = new Vector2(transform.position.x, -4.29f);
        }

        if (transform.position.x <= -8.45)
        {
            transform.position = new Vector2(-8.44f, transform.position.y);
        }

        if (transform.position.x >= 8.45)
        {
            transform.position = new Vector2(8.44f, transform.position.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "explosive")
        {
            lives = lives - 1;
            //(explosion, new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y), Quaternion.identity);
        }
    }
}