using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_move : MonoBehaviour
{
    float posx;
    float posy;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(5, 5);
        transform.position= (new Vector2(0, 0));
        posx = 1;
        posy = 1;
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(5* posx, 5* posy) * Time.deltaTime * speed);
        if (transform.position.y >=17.5)
        {
            posy = -1;
        }
        if (transform.position.x >=23.5)
        {
            posx = -1;
        }
        if (transform.position.x <=-23.5)
        {
            posx = 1;
        }
        if (transform.position.y <=-17.5)
        {
            posy = 1;
        }
    }
}
