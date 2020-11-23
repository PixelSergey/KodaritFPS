﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider who){
        if(who.gameObject.tag == "Player"){
            LoadScene();
        }
    }

    public void LoadScene(){
        SceneManager.LoadScene(0);
    }
}
