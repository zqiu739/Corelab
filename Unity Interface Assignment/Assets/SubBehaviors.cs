using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBehaviors : MonoBehaviour
{
    public GameObject sovtor;
    float spawnRate;
    float nextTor;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 2;
        nextTor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-.05f, 0));

        if (transform.position.x <= -8)
        {
            Destroy(this.gameObject);
        }

        if (Time.time > nextTor)
        {
            nextTor = Time.time + spawnRate;
            Instantiate(sovtor, new Vector3(transform.position.x - 1.15f, transform.position.y - .1f), Quaternion.identity);
        }
    }
}
