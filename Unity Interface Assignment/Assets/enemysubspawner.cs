using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysubspawner : MonoBehaviour
{
    public GameObject sovsub;
    float spawnPosy;
    float spawnRate;
    float nextEnemy;
    Vector2 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 0;
        nextEnemy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnRate = Random.Range(.8f, 2f);

        if (Time.time> nextEnemy)
        {
            nextEnemy = Time.time + spawnRate;
            spawnPosy = Random.Range(2.3f, -4.3f);
            spawnPos = new Vector2(10, spawnPosy);
            Instantiate(sovsub, spawnPos, Quaternion.identity);
        }
    }
}
