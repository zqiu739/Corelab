using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static GameManagement Will;

    private void Awake()
    {
        if (Will == null)
        {
            Will = this;
            DontDestroyOnLoad(this);
        }
        else if (Will != this)
        {
            Destroy(this.gameObject);
        }
    }

    public Text start;
    public Slider difficulty;
    public float speed;

    public void SliderChange()
    {
        Debug.Log("pickle");
        speed = difficulty.value;
        start.text = speed.ToString();
    }

    public void OnClicked()
    {
        SceneManager.LoadScene(1);
    }

    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
