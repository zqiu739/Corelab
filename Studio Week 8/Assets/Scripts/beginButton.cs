using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class beginButton : MonoBehaviour
{
    public void onClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void onClicked2()
    {
        SceneManager.LoadScene(0);
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
