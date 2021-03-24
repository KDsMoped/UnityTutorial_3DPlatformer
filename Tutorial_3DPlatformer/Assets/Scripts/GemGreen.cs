using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGreen : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource CollectSound;

    void OnTriggerEnter()
    {
        GlobalScore.CurrentScore += 500;
        CollectSound.Play();
        Destroy(gameObject);
    }
}
