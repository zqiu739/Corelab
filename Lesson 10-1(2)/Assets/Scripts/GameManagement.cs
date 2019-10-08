using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{

    public static GameManagement Larry;

    private void Awake()
    {
        if (Larry == null)
        {
            Larry = this;
            DontDestroyOnLoad(this);
        }
        else if (Larry != this) {
            Destroy(gameObject);
        }
    }

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 3)
        {
            score = 4;
            SceneManager.LoadScene(2);
        }
    }

    public void LoseGame()
    {
        SceneManager.LoadScene("Endgame");
        score = 0;
        UpdateScore();
    }
}
