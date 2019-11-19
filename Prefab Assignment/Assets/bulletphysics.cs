using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletphysics : MonoBehaviour
{
    //public GameObject bullet_p;
    Rigidbody2D rb;
    float forceamount;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        forceamount = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = (mousePos - transform.position);
            rb.AddForce(new Vector2(direction.x, direction.y) * forceamount, ForceMode2D.Impulse);
        }
        if (transform.position.x >= 6)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
            if (collision.gameObject.tag == "zombie")
            {
                Destroy(this.gameObject);
                collision.gameObject.transform.Translate(new Vector2(0, -.3f));
            }
            if (collision.gameObject.tag == "ground")
            {
                Destroy(this.gameObject);
            }

    }

}
//Vector3 worldPoint = Camera.main.ScreenToViewportPoint(Input.mousePosition);
//Debug.Log("clicked!" + worldPoint.x + " " + worldPoint.y);
//            Vector3 direction = (worldPoint - transform.position);
//rb.AddForce(new Vector2(direction.x, direction.y), ForceMode2D.Impulse);