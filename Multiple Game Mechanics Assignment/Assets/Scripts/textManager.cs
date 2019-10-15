using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textManager : MonoBehaviour
{
    public static textManager Continue;

    private void Awake()
    {
        if (Continue == null)
        {
            Continue = this;
            DontDestroyOnLoad(this);
        }
        else if (Continue != this)
        {
            Destroy(gameObject);
        }
    }

    public Text instructions;
    float timer;
    int sceneNo;

    // Start is called before the first frame update
    void Start()
    {
        instructions.text = "Use WASD/Arrow Keys to move. Get in the hole. Seems like a simple task.";
        sceneNo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 30)
        {
            instructions.text = "Not so easy, huh? Keep trying. you'll get there... eventually.";
        }

        if (sceneNo == 1)
        {
            instructions.text = "Time to manipulate gravity. Another simple task. Should take no time.";
        }

        if (sceneNo == 2)
        {
            instructions.text = "Time for some puzzles... I made the hole a little bigger for you.";
        }
    }

    public void texty()
    {
        sceneNo += 1;
    }
}
