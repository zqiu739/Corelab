using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tringle_pringle : MonoBehaviour
{
    public float speed;
    public float size;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        transform.position = new Vector2(0, 0);
        transform.localScale = new Vector2(5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0+ -speed, 0+speed)*Time.deltaTime);
        if (transform.position.y >= 20)
        {
            transform.position = new Vector2(20, -transform.position.y);
        }

    }
}
    
