using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOpath : MonoBehaviour
{
    public float speed;
    float posy;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(-5, 2);
        speed = 5;
        posy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(speed, posy) * Time.deltaTime);
        if (transform.position.x >= 8)
        {
            speed = speed * -1;
            posy = Random.Range(-2.0f, 2.0f);
            transform.position = (new Vector2(transform.position.x, Random.Range(-2.0f, 5.0f)));
        }
        if (transform.position.x <= -8)
        {
            speed = speed * -1;
            posy = Random.Range(-2.0f, 2.0f);
            transform.position = (new Vector2(transform.position.x, Random.Range(-2.0f, 5.0f)));
        }
        if (transform.position.y <= -2)
        {
            posy = 0;
        }
    }
}
