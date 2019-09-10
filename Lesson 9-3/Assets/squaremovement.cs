using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squaremovement : MonoBehaviour
{

    Vector2 direction;
    float spinForce;
    Rigidbody2D rb;
    float max_y;
    float max_x;

    // Start is called before the first frame update
    void Start()
    {

        direction = new Vector2(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        spinForce = Random.Range(-20.0f, 20.0f);
        max_x = 20;
        max_y = 20;
        rb = GetComponent<Rigidbody2D>();
        rb.AddTorque(spinForce);
        rb.AddForce(direction, ForceMode2D.Impulse);

        // Update is called once per frame
        void Update()
        {
            if (transform.position.x > max_x)
            {
                transform.position = new Vector2(-max_x, transform.position.y);
            }
            if (transform.position.x < max_x)
            {
                transform.position = new Vector2(max_x, transform.position.y);
            }
            if (transform.position.y < max_y)
            {
                transform.position = new Vector2(transform.position.x, -max_y);
            }
            if (transform.position.y > max_y)
            {
                transform.position = new Vector2(transform.position.x, max_y);
            }
            //if (Input.GetMouseButtonDown(0))
            //{
            //    Vector3 worldPoint = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            //    Debug.Log("clicked!" + worldPoint.x+ " "+worldPoint.y);
            //    Vector2 mousePoint = new Vector2(worldPoint.x, worldPoint.y);
            //    Vector
        }
        //?Debug.Log(Input.mousePosition);
        //Wrapping.AddForce(direction.Input.mousePosition);

    }

    
}
