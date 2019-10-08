using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class answerBehavior : MonoBehaviour
{
    public static int score;
    public static int wrong;
    public Text scoreText;
    public Text wrongText;
    public Button no1;
    public Button no2;
    public Button no3;
    public Button no4;
    public Button Next;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        wrong = 0;
        no1.interactable = true;
        no2.interactable = true;
        no3.interactable = true;
        no4.interactable = true;
        Next.interactable = false;
    }

    public void ScoreKeeper()
    {
        UIManager.scoreInterface.scoreKeeper(score);
    }

    public void Wrong()
    {
        UIManager.scoreInterface.incorrect(wrong);
    }

    public void Correct()
    {
        score++;
        ScoreKeeper();
        //scoreText.text = "Questions Correct: " + score.ToString() + "/8";
        no1.interactable = false;
        no2.interactable = false;
        no3.interactable = false;
        no4.interactable = false;
        Next.interactable = true;
    }

    public void Incorrect()
    {
        wrong++;
        Wrong();
        //wrongText.text = "Incorrect: " + wrong.ToString();
        no1.interactable = false;
        no2.interactable = false;
        no3.interactable = false;
        no4.interactable = false;
        Next.interactable = true;
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
