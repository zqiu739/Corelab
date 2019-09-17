using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Using_inputs : MonoBehaviour
{
    float horz;
    float vert;
    Rigidbody2D rb;
    public float forceamount;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        forceamount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        //Debug.Log(horz + " " + vert);

        rb.AddForce(new Vector2(horz, vert)*forceamount);




        //transform.Translate(horz * Time.deltaTime, vert * Time.deltaTime, 0);
        //GetKeyDown(per frame) vs GetKey(continuous)

        //if (Input.GetKey(KeyCode.G))
        //{
        //    Debug.Log("hitting g");
        //    if (Input.GetKey(KeyCode.H))
        //    {
        //        Debug.Log("h and g");
        //    }
        //}
        //if (Input.GetKey(KeyCode.H))
        //{
        //    Debug.Log("hitting h");
        //}
    }
}
