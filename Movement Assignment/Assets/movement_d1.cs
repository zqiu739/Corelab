using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_d1 : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
        transform.position = new Vector2(0, 0);
        transform.localScale = new Vector2(5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(Random.Range(-1,2), Random.Range(-1,2)));
        {
            if(transform.position.x>=26)
            {
                transform.position = new Vector2(25, transform.position.y);
            }
            if (transform.position.x <= -26)
            {
                transform.position = new Vector2(-25, transform.position.y);
            }
            if (transform.position.y>=20)
            {
                transform.position = new Vector2(transform.position.x, 19);
            }
            if (transform.position.y <= -20)
            {
                transform.position = new Vector2(transform.position.x, -19);
            }
        }
    }
}