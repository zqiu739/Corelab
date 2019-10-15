using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonBehavior : MonoBehaviour
{
    public Button start;
    public Slider difficulty;
    float No;

    // Start is called before the first frame update
    void Start()
    {
        difficulty.minValue = 0;
        difficulty.maxValue = 5;
        start.GetComponentInChildren<Text>().text = "Pick a number";
        No = 0;
    }

    public void onClick()
    {
        if (No >= 1)
        {
            SceneManager.LoadScene(1);
        }
    }

    //Update is called once per frame
    void Update()
    {
        if (difficulty.value >= 1)
        {
            start.GetComponentInChildren<Text>().text = "difficulty: " + Mathf.Round(difficulty.value);
            No = Mathf.Round(difficulty.value);
            speedCarrier.speed.boxMove(No);
        } 
    }
}
