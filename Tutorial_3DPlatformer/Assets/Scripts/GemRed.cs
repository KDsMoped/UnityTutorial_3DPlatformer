using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemRed : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource CollectSound;

    void OnTriggerEnter()
    {
        GlobalScore.CurrentScore += 250;
        CollectSound.Play();
        Destroy(gameObject);
    }
}
