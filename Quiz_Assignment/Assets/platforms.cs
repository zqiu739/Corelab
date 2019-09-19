using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforms : MonoBehaviour
{
    public GameObject platform_s;
    float timer;
    float width;
    public float interval;
    bool helpme;

    // Start is called before the first frame update
    void Start()
    {
        width = -8;
        timer = 0;
        timer += Time.deltaTime;
        helpme = true;
    }

    // Update is called once per frame
    void Update()

    {
        if (helpme == true)
        {
            width = width + 2;
            Instantiate(platform_s, new Vector3(width, -3, 0), Quaternion.identity);
            Debug.Log("time=" + timer);
            if (width >=16)
            {
                helpme = false;
            }
        }
    }
}
