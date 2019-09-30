using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    bool gunaim;
    public Transform Bulletmov;
    public GameObject bullet_p;
    //Rigidbody2D rb;
    float forceamount;

    // Start is called before the first frame update
    void Start()
    {
        gunaim = true;
        //rb = GetComponent<Rigidbody2D>();
        forceamount = 40;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (mousePos.x >= -3)
        {
            if (mousePos.y < 2)
            {
                if (mousePos.y > -2)
                {
                    gunaim = true;
                    transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position) * Quaternion.Euler(0, 0, 90);

                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        Instantiate(bullet_p, Bulletmov.position, Bulletmov.rotation);
                    }
                }
            }
        }
    }
}

