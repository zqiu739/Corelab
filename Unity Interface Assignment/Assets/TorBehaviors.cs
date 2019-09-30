using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorBehaviors : MonoBehaviour
{
    float timer;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector2(amsub.transform.position.x, amsub.transform.position.y);
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.Translate(new Vector2(.2f * timer, 0));

        if (transform.position.x >= 7)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Instantiate(explosion, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
        }
    }
}

