using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wordrecognizer : MonoBehaviour
{
    List<string> letters = new List<string>();
    string[] mywords = new string[] { "BEANS", "CHICKEN", "EGGS","CHEESE","TOMATO"};
    string myword;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        myword = mywords[Random.Range(0, mywords.Length - 1)];
        text.text = myword;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        if (Event.current.type == EventType.KeyDown && Event.current.keyCode != KeyCode.None)
        {
            Debug.Log("Current detected event:" + Event.current);
            letters.Add(Event.current.keyCode.ToString());
            //foreach (string letter in letters) { Debug.Log(letters); }

            for (int i = 0; i <= letters.Count -1; i++)
            {
                if (letters[i] == myword.Substring(i, 1))
                {
                    Debug.Log("yay you typing");
                    text.color = Color.green;

                    if (letters.Count == myword.Length)
                    {
                        Debug.Log("you typed" + myword + ".yay you are a typer");
                        text.color = Color.green;
                        letters.Clear();
                        myword = mywords[Random.Range(0, mywords.Length - 1)];
                        text.text = myword;
                        text.color = Color.white;
                    }

                }
                else
                {
                    Debug.Log("boo you suck");
                    letters.Clear();
                    text.color = Color.red;
                } 
            }   
        }
    } 
}
