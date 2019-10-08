using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhind : MonoBehaviour
{
    float spawnRate;
    float nextEnemy;
    public GameObject hind;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 3;
        nextEnemy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnRate = Random.Range(3, 9);

        if (Time.time > nextEnemy)
        {
            nextEnemy = Time.time + spawnRate;
            Instantiate(hind, new Vector3(10,4,6),Quaternion.Euler(0,0,6));
        }
    }
}
