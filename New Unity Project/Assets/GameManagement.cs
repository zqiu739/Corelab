using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public GameObject platform_p;
    float width;
    float height;

    // Start is called before the first frame update
    void Start()
    { 
        for(int i = -8; i <= 8 ;i += 2)
        {
            Instantiate(platform_p, new Vector2(1, -2), Quaternion.identity;
        }

        width = Screen.width;
        height = Screen.height;

        Vector2 screenUnits = Camera.main.ScreenToWorldPoint(new Vector3(width, height, 0));
        Debug.Log(screenUnits);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
