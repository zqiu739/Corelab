using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxBehavior : MonoBehaviour
{
    public static boxBehavior square;

    public float speed;
    Vector3 mousePos;
    Ray ray;
    RaycastHit hit;
    public float timer;
    public Text time;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        squareMove(speed);
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position ,mousePos , speed * Time.deltaTime);
        time.text = timer.ToString();
        //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if (Physics.Raycast(ray, out hit))
        //{
        //    Debug.Log(hit.collider.name);
        //}
    }

    public void squareMove(float squareMov)
    {
        speed = squareMov;
    }

    private void OnMouseOver()
    {
        Debug.Log(gameObject.name);
        if (gameObject.tag == "Player")
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }
    }
}
