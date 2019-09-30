using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiespawn : MonoBehaviour
{
    public GameObject zombie_p;
    float timer;
    float spawnamount;
    bool spawner;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(8, 0);
        timer = 0;
        spawnamount = 8;
        spawner = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //zombie_p.transform.Translate(new Vector2(-3, 0));

        if (spawner == true)
        {
            if (timer >= 0)
            {
                spawnamount += Random.Range(0,2f);
                Instantiate(zombie_p, new Vector3(spawnamount, 0, 0), Quaternion.identity);
            }
            if (spawnamount >= 38)
            {
                spawner = false;
            }
        }
    }
}
