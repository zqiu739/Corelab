using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bacteriaBehavior : MonoBehaviour
{
    float timer;
    float xPos;
    float yPos;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(Random.Range(.2f,.4f),Random.Range(.2f, .4f));
        timer = 0;
        gameObject.GetComponent<Renderer>().material.color = new Color32((byte)Random.Range(0, 200), (byte)Random.Range(0, 200), 60, 255);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(xPos, yPos) * Time.deltaTime);
        transform.eulerAngles = Vector3.forward * Random.Range(1, 180);
        timer += Time.deltaTime;
        if (timer >= .5f)
        {
            xPos = Random.Range(-4f, 4f);
            yPos = Random.Range(-4f, 4f);
            timer = 0;
        }

        if(transform.position.x <= -9.1)
        {
            transform.position = new Vector2(transform.position.x + .1f, transform.position.y);
        }

        if (transform.position.x >= 9.1)
        {
            transform.position = new Vector2(transform.position.x - .1f, transform.position.y);
        }

        if (transform.position.y <=- 6.1)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + .1f);
        }

        if (transform.position.y >= 6.1)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - .1f);
        }
    }
}
