﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    private void FixedUpdate()
    {
        Destroy(gameObject, .9f);
    }

}
