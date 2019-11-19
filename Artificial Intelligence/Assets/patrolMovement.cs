using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolMovement : MonoBehaviour
{
    public GameObject[] patrolpoints;
    int whichPoint;
    public static bool isChasing;
    float distance;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        whichPoint = 0;
        isChasing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, Time.deltaTime * 2.5f);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolpoints[whichPoint].transform.position, Time.deltaTime);
            distance = Vector2.Distance(transform.position, patrolpoints[whichPoint].transform.position);
            if(distance <= 0.01f)
            {
                whichPoint++;
            }
            if (whichPoint >= 4)
            {
                whichPoint = 0;
            }
        }
    }
}
