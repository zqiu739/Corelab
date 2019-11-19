using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    float speed;
    float size;
    public Text state;
    public GameObject predator;
    Vector2 player;
    float xtravel;
    float ytravel;
    

    // Start is called before the first frame update
    void Start()
    {

        speed = .05f;
        state.text = "We are nothing but small blip on a cosmic timeline.";
        size = 1;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += Movement * speed;
        state.CrossFadeAlpha(0.0f, 2f, false);
        player = new Vector2(transform.position.x, transform.position.y);

        if (transform.position.y >= 5.5f)
        {
            transform.position = new Vector2(transform.position.x, -5.49f);
        }

        if (transform.position.y <= -5.5f)
        {
            transform.position = new Vector2(transform.position.x, 5.49f);
        }

        if (transform.position.x <= -8.5)
        {
            transform.position = new Vector2(8.49f, transform.position.y);
        }

        if (transform.position.x >= 8.5)
        {
            transform.position = new Vector2(-8.49f, transform.position.y);
        }

        if (size >= 2 && size <3)
        {
            state.text = "Oh, the world is so much larger than we are.";
            state.CrossFadeAlpha(1.0f, 0.05f, false);

        }

        if (size >= 3 && size < 4)
        {
            state.text = "I don't have much time to grow. I'm stagnant.";
            state.CrossFadeAlpha(1.0f, 0.05f, false);
        }

        if (size >= 4 && size < 5)
        {
            state.text = "I wish I was much larger than I am";
            state.CrossFadeAlpha(1.0f, 0.05f, false);
        }

        if (size > 5)
        {
            predator.transform.Translate(new Vector2(-.05f, 0) * Time.deltaTime * 70);
            if (transform.position.x <= -8.45)
            {
                transform.position = new Vector2(-8.44f, transform.position.y);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "food")
        {
            Destroy(collision.gameObject);
            size += .05f;
            transform.localScale = new Vector2(size, size);
        }
        if (collision.gameObject.tag == "predator")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);

        }
    }

}
