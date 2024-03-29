﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinMaker : MonoBehaviour
{
    public GameObject coin_prefab;
    int coinCount;
    int maxCoins;

    public Slider coinSlider;
    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        maxCoins = 30;
        //allCoins = GameObject.FindGameObjectsWithTag("coin");
    }

    private void Update()
    {
        SliderUpdate();
    }

    public void CreateCoin() {
        Instantiate(coin_prefab, new Vector2(Random.Range(-6f, 6f), 5), Quaternion.identity);
        coinCount++;
        coinSlider.value = coinCount;
        if (coinCount > maxCoins) {
            RemoveCoin();
        }
        //Debug.Log(coinCount);

    }

    public void RemoveCoin() {
        GameObject[] allCoins;
        allCoins = GameObject.FindGameObjectsWithTag("coin");
        if (allCoins.Length >= 1)
        {
            int randomCoin = Random.Range(0, allCoins.Length - 1);
            Destroy(allCoins[randomCoin]);
            coinCount--;
            coinSlider.value = coinCount;
        }

    }

    public void SliderUpdate() {
        //Debug.Log(coinSlider.value);
        if (coinSlider.value > coinCount)
        {
            CreateCoin();
        }
        else if (coinSlider.value < coinCount) {
            RemoveCoin();
        }
    }

    public void TextUpdate() {
        Debug.Log(inputField.text);
        if(inputField.text == "bonus")
        {
            Debug.Log("BONUSS");
            maxCoins = 40;
            coinSlider.maxValue = 40;
            coinCount = 40;

            int difference = maxCoins - coinCount;
            for(int i = 0; i <= difference; i++)
            {
                CreateCoin();
            }
            inputField.text = "";
        }
        else if(inputField.text == "blue")
        {
            coin_prefab.GetComponent<SpriteRenderer>().color = Color.blue;
            inputField.text = "";
        }
        //else if(inputField.text == "rainbow")
        //{
        //    for(int i=0; i <= allCoins.Length-1 ; 1++)
        //    {
        //        allCoins[i].GetComponent<SpriteRenderer>().color = Random.ColorHSV()
        //    }
        //}
    }

}
