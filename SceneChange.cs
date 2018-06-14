﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    [SerializeField]
    private string newLevel;
    void OnTriggerEnter2D(Collider2D other)
    {



        if(other.CompareTag("Player"))
        {

            SceneManager.LoadScene(newLevel);

        }
    }
}
