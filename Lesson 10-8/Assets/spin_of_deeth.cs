using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spin_of_deeth : MonoBehaviour
{
    public Slider s;
    Animator anim;
    float sValue;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        sValue = s.value;
        anim.speed = sValue;

    }

    public void AnimaationEvent()
    {
        Debug.Log("pickle");
    }
}
