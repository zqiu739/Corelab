using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlemovement : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            
        {
            Debug.Log("Pressed Primary button" + Input.mousePosition);
            Vector3 worldPoint = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log("clicked!" + worldPoint.x + " " + worldPoint.y);
            Vector3 direction = (worldPoint - transform.position);
            rb.AddForce(new Vector2(direction.x, direction.y), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}

