using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombiemovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-0.01f, 0));

        if (transform.position.y <= -1.3)
        {
            Destroy(this.gameObject);
        }
    }
}
