using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomColor : MonoBehaviour
{
    Color[] colors = new Color[]{Color.red, Color.blue, Color.green };
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(AutoColorChange());
        StartCoroutine(ThreeColorChange());
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;  
    }

    IEnumerator AutoColorChange()
    {
        while (true)
        {
            GetComponent<SpriteRenderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator ThreeColorChange()
    {
        foreach(Color c in colors)
        {
            GetComponent<SpriteRenderer>().material.color = c;
            yield return new WaitForSeconds(.5f);
        }
    }
}
