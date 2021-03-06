﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/* Copyright © 2020 WestMac All Rights Reserved */

public class MenuGUIFunctions : MonoBehaviour
{
    //Sets the level to Infinite. Begins the game.
    public void StartGame()
    {
        SceneManager.LoadScene("Infinite");
    }

    //Quits game
    public void Exit()
    {
        Application.Quit();
    }

    //Opens my github.
    public void OpenGithub()
    {
        Application.OpenURL("https://github.com/westonmcnamara");
    }

    public void OpenMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void ReloadThisLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
