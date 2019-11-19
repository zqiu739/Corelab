using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bacSpawner : MonoBehaviour
{
    public GameObject bacteria;
    float spawnRate;
    float nextEnemy;
    float upOrDown;
    float spwnPosy;
    float spwnPosx;
    Vector2 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        nextEnemy = 0;
        spwnPosx = 0;
        spwnPosy = 0;
        upOrDown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnRate = Random.Range(.8f, 1f);
        spwnPosx = Random.Range(-9, 9);
        upOrDown = Random.Range(1, 3);

        if (upOrDown > 0 && upOrDown < 2)
        {
            spwnPosy = (-6);
        }

        if (upOrDown > 1 && upOrDown < 3)
        {
            spwnPosy = (6);
        }

        if (Time.time > nextEnemy)
        {
            nextEnemy = Time.time + spawnRate;
            spawnPos = new Vector2(spwnPosx, spwnPosy);
            Instantiate(bacteria, spawnPos, Quaternion.identity);
        }





    }
}
