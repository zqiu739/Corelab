using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrapping : MonoBehaviour
{
    float max_y;
    float max_x;

    // Start is called before the first frame update
    void Start()
    {

    }

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
    }
}