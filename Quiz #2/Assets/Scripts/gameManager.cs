using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager boxSpeed;
    public GameObject square;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(square, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void difficulty(float boxMov)
    //{
    //    speed = boxMov;
    //}
}
