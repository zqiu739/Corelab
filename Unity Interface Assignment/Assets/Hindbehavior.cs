using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hindbehavior : MonoBehaviour
{
    public GameObject depthcharge;
    float spawnRate;
    float nextCharge;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 2;
        nextCharge = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnRate = Random.Range(1f, 4f);
        transform.Translate(new Vector2(-.07f, 0));
        transform.position = new Vector3(transform.position.x, 4);

        if (transform.position.x <= -11)
        {
            Destroy(this.gameObject);
        }

        if (Time.time > nextCharge)
        {
            nextCharge = Time.time + spawnRate;
            Instantiate(depthcharge, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
        }
    }
}
