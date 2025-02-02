﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float scoreIncreasedPerSecond;

    void Start()
    {
        scoreAmount = 0f;
        scoreIncreasedPerSecond = 1f;

    }

    void Update()
    {
        scoreText.text = "Score: " + (int)scoreAmount;
        scoreAmount += scoreIncreasedPerSecond * Time.deltaTime;
    }

}
