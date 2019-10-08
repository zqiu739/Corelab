using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager scoreInterface;

    private void Awake()
    {
        if (scoreInterface == null)
        {
            scoreInterface = this;
            DontDestroyOnLoad(this);
        }
        else if (scoreInterface != this)
        {
            Destroy(gameObject);
        }
    }

    public int noScore;
    public int noWrong;
    public int scene;
    public int Qno;
    public Text scoreText;
    public Text wrongText;
    public Text HQ;

    // Start is called before the first frame update
    void Start()
    {
        noScore = 0;
        noWrong = 0;
        scene = 1;
        Qno = 1;

    }

    public void scoreKeeper(int score)
    {
        Qno++;
        noScore++;
        scoreText.text = "Questions Correct: " + noScore.ToString() + "/8";
       //HQ.text = "Question #" + Qno;
        scene++;
    }

    public void incorrect(int wrong)
    {
        Qno++;
        noWrong++;
        wrongText.text = "Incorrect: " + noWrong;
        //HQ.text = "Question #" + Qno;
        scene++;
    }

    public void Next()
    {
        SceneManager.LoadScene(scene);
        HQ.text = "Question #" + Qno;
        if (scene > 8)
        {
            if (noScore <= 8)
            {
                SceneManager.LoadScene(9);
                if (noScore <= 7)
                {
                    SceneManager.LoadScene(10);
                    if (noScore <= 5)
                    {
                        SceneManager.LoadScene(11);
                        if (noScore <= 2)
                        {
                            SceneManager.LoadScene(12);
                            if (noScore == 0)
                            {
                                SceneManager.LoadScene(13);
                            }
                        }
                    } 
                }
            }

            Destroy(this.gameObject);
        }
    }
    //// Update is called once per frame
    //void Update()
    //{

    //}
}
