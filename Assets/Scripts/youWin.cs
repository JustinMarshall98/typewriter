﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youWin : MonoBehaviour
{
    void Update(){
        if (Input.GetKeyDown(KeyCode.Q)){
            SceneManager.LoadScene("MainMenu");
        }
    }
}