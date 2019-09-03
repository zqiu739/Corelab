using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex_moves : MonoBehaviour
{
    public float speed;
    public float size;
    public GameObject diamond;
    public GameObject seconddiamond;
    public GameObject thirddiamond;
    public GameObject fourthdiamond;

    // Start is called before the first frame update
    void Start()
    {
        transform.position=(new Vector2(-26, 0));
        speed = 1;
        size = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x>=32)
        {
            transform.position = new Vector2(-26, transform.position.y);
        }
        transform.localScale = (new Vector2(3 * size, 3 * size));
        transform.Translate(new Vector2(5, 0)*Time.deltaTime *speed);
        diamond.transform.position = new Vector2(transform.position.x - 3, transform.position.y - 3);
        seconddiamond.transform.position = new Vector2(transform.position.x - 6, transform.position.y - 6);
        thirddiamond.transform.position = new Vector2(transform.position.x - 3, transform.position.y + 3);
        fourthdiamond.transform.position = new Vector2(transform.position.x - 6, transform.position.y + 6);
        if (size > 1)
        {
            diamond.transform.localScale = (new Vector2(3, 3) * size);
            seconddiamond.transform.localScale = (new Vector2(3, 3) * size);
            thirddiamond.transform.localScale = (new Vector2(3, 3) * size);
            fourthdiamond.transform.localScale = (new Vector2(3, 3) * size);
        }
    }
}
