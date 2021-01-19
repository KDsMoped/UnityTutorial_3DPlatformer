using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemSilver : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource CollectSound;

    void OnTriggerEnter()
    {
        GlobalScore.CurrentScore += 1000;
        CollectSound.Play();
        Destroy(gameObject);
    }
}
