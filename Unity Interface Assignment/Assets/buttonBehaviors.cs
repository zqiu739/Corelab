using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonBehaviors : MonoBehaviour
{
    public GameObject tor;
    public GameObject amsub;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector2(-4,0);
    }

    public void fire()
    {
        Instantiate(tor, new Vector3(amsub.transform.position.x + 1.15f, amsub. transform.position.y -.1f, 0), Quaternion.identity);
        Debug.Log("pressed");
    }

    public void missile()
    {

    }
    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
