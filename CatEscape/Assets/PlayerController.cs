﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    void Start()
    {
    }

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}