using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missiletraj : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject Fire;
    public GameObject ufo;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(0, -4);
        rb.gravityScale = 0;
        //makes sprite invisible
        Fire.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Fire.GetComponent<Renderer>().enabled = false;
        //found this script on the internet
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        Fire.transform.position = (new Vector2(transform.position.x, transform.position.y));
        Fire.transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        //A bunch of failed scripts
        //if (Input.GetMouseButtonDown(0))
        //{
        //    transform.position = new Vector2(0, Input.mousePosition.y);
        //transform.Translate(new Vector2(Input.mousePosition.x - transform.position.x, Input.mousePosition.y + transform.position.y) * Time.deltaTime);
        //transform.eulerAngles = Vector3.forward * mousex;

        if (Input.GetMouseButtonDown(0))

        {
            //Borrowed from class
            Fire.GetComponent<Renderer>().enabled = true;
            rb.gravityScale = 1;
            Debug.Log("Pressed Primary button" + Input.mousePosition);
            Vector3 worldPoint = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log("clicked!" + worldPoint.x + " " + worldPoint.y);
            Vector3 direction = (worldPoint - transform.position);
            rb.AddForce(new Vector2(direction.x, direction.y), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "UfO")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}