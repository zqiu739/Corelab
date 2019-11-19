using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    float speed;
    int coinCount;
    public Slider coinBar;
    List<GameObject> coins = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        coinBar.maxValue = 24;
        coinBar.minValue = 0;
        coinBar.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "coin")
        {
            collision.gameObject.SetActive(false);
            coins.Add(collision.gameObject);
            coinCount++;
            coinBar.value = coinCount;
        }

        if(collision.gameObject.tag == "patrol")
        {
            
            if (coins.Count > 0)
            {
                coinCount--;
                int randomCoin = Random.Range(0, coinCount);
                coins[randomCoin].gameObject.SetActive(true);
                coins.Remove(coins[randomCoin]);
                coinBar.value = coinCount;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("POND");
        patrolMovement.isChasing = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        patrolMovement.isChasing = false;
    }
}
