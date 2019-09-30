using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterBehavior : MonoBehaviour
{
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        //timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //timer -= Time.deltaTime;
        transform.Translate(new Vector2(-.05f, 0));

        if (transform.position.x <= -18)
        {
            transform.position = new Vector2(17.8f, 0);
        }

    }
}
