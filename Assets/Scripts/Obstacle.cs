﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/* Copyright © 2020 WestMac All Rights Reserved */

//Uses a timestamp method to destroy the object after player zooms by it.
public class Obstacle : MonoBehaviour
{
    //Time until the obstacle is destroyed.
    public float deathTime = 5.0f;

    //Used to keep track of time since creation.
    private float initTime;

    // Start is called before the first frame update
    void Start()
    {
        //Time since level loaded.
        initTime = Time.timeSinceLevelLoad;
    }

    private void Update()
    {
        //If the object has been around lounger than deathtime destroy it.
        if (Time.timeSinceLevelLoad - initTime > deathTime)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        //If the block detects a collision from the player tag, end the game.
        if (other.tag == "Player")
        {
            //Requires tag.
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().EndGame();
            Debug.Log("Game Over");
        }
    }
}
