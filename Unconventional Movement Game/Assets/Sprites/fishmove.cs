using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishmove : MonoBehaviour
{
    public float speed;
    float posy;
    SpriteRenderer fl;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(Random.Range(- 8,8), Random.Range(-4,2));
        speed = Random.Range(5f, 7f);
        posy = 0;
        fl = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector2(speed, posy) * Time.deltaTime);
        if (transform.position.x >= 8)
        {
            fl.flipX = true;
            speed = speed * -1;
            posy = Random.Range(-2.0f, 2.0f);
            transform.position = (new Vector2(transform.position.x, Random.Range(-2.0f, 2.99f)));
        }
        if (transform.position.x <= -8)
        {
            fl.flipX = false;
            speed = speed * -1;
            posy = Random.Range(-2.0f, 2.0f);
            transform.position = (new Vector2(transform.position.x, Random.Range(-2.0f, 2.99f)));
        }
        if (transform.position.y <= -4)
        {
            posy = 0;
        }
        if (transform.position.y >= 2.5f)
        {
            posy = 0;
        }
    }
}