using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedCarrier : MonoBehaviour
{
    public static speedCarrier speed;

    private void Awake()
    {
        if (speed == null)
        {
            speed = this;
            DontDestroyOnLoad(this);
        }
        else if (speed != this)
        {
            Destroy(gameObject);
        }
    }


    public float boxSpeed;

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        //boxBehavior.square.squareMove(boxSpeed);
    }

    public void boxMove(float Speed)
    {
        boxSpeed = Speed;
    }
}
