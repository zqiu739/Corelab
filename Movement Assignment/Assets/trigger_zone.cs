using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_zone : MonoBehaviour
{
    Rigidbody2D rb;
    public float forceamount;
    public GameObject[] Planets = new GameObject[4];

    Vector3 planet_pos;
    Vector3 direction;
    //Vector3 distance;
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //planet_pos = Planet.transform.position;
        //rb.AddForce(Vector2.left * 10, ForceMode2D.Impulse);
        distance = Vector3.Distance(Planets[0].transform.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject planet in Planets)
        {
            //temporary variable
            float distcheck = Vector3.Distance(planet.transform.position, transform.position);
            if (distcheck < distance)
            {
                planet_pos = planet.transform.position;
                distance = distcheck;
            }
        }
        direction = planet_pos - transform.position;
        rb.AddForce(direction * forceamount);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //rb.AddForce(Vector2.up * forceamount);
        //rb.AddForce(new Vector2(0, 1));  is the same as rb.AddForce(Vector.2.up);
        //Debug.Log("triggered!!");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
