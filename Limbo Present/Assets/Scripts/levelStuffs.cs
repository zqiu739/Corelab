using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelStuffs : MonoBehaviour
{
    public GameObject Door;
    bool detectCollision;

    // Start is called before the first frame update
    void Start()
    {
        detectCollision = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(detectCollision);
        if(Door.transform.position.y > 5)
        {
            Door.transform.position = new Vector2(Door.transform.position.x, 5);
        }

        if(Door.transform.position.y < 2.683f)
        {
            Door.transform.position = new Vector2(Door.transform.position.x, 2.682f);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Door.transform.Translate(new Vector2(0, 8) * Time.deltaTime);
            detectCollision = true;
        }
    }
}
