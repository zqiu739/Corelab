using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float timer;
    public GameObject Circle;
    float posx;
    float posy;
    public float freq;
    public float amp;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position);
        transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-20,20));
        speed = 5;
        timer=0;
        Circle.transform.position= new Vector2(0,0);
        freq=1;
        amp=1;
        //transform.Translate(new Vector2(10, 10));

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector2(1, 0)*Time.deltaTime*speed);
        if(timer>=1)
        {
            transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-20,20));
            timer=0;
        }
        timer += Time.deltaTime;

posx=Mathf.Sin(Time.time*freq)*Mathf.Sin(Time.time)*amp;
posy=Mathf.Cos(Time.time*freq)*Mathf.Sin(Time.time);
Debug.Log(posx);

Circle.transform.position= new Vector2(posx+ transform.position.x, posy+ transform.position.y);
    }
}
