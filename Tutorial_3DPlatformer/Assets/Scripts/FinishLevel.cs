using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public GameObject LevelMusic;
    public AudioSource LevelComplete;
    public GameObject LevelTimer;


    void OnTriggerEnter()
    {
        LevelMusic.SetActive(false);
        LevelTimer.SetActive(false);
        LevelComplete.Play();
    }
}
