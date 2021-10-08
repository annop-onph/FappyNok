﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteConstantMove : MonoBehaviour
{
    private gameManager GameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameManager = gameController.gameObject.GetComponent<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((GameManager.moveVector * GameManager.moveSpeed * Time.deltaTime));
    }
}
