using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public GameObject LevelMusic;
    public AudioSource LevelComplete;
    public GameObject LevelTimer;
    public GameObject TimeLeft;
    public GameObject Score;
    public GameObject TotalScore;

    void OnTriggerEnter()
    {
        LevelMusic.SetActive(false);
        LevelTimer.SetActive(false);
        LevelComplete.Play();

        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        yield return new WaitForSeconds(1.0f);

        TimeLeft.SetActive(true);
        yield return new WaitForSeconds(0.5f);

        Score.SetActive(true);
        yield return new WaitForSeconds(0.5f);

        TotalScore.SetActive(true);
        yield return new WaitForSeconds(0.5f);
    }
}
