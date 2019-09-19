using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab_box : MonoBehaviour
{
    public GameObject platform_s;
    float timer;
    public float interval;

    // Start is called before the first frame update
    void Start()
    {
        GameObject s;
        s = Instantiate(platform_s, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        GameObject s;
        s = Instantiate(platform_s, new Vector3(0, 0, 0), Quaternion.identity);
        float width = Random.Range(3, 8);
        s.transform.localScale = new Vector2(width, s.transform.localScale.y);


    }
}
