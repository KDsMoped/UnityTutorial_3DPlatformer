using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public GameObject LevelMusic;
    public AudioSource LevelComplete;
    public GameObject LevelTimer;
    public GameObject TimeLeft;
    public GameObject Score;
    public GameObject TotalScore;
    public GameObject LevelBlocker;
    public GameObject FadeOut;

    private int timeCalc;
    private int scoreCalc;
    private int totalScore;


    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;

        LevelBlocker.SetActive(true);
        LevelBlocker.transform.parent = null;

        TimeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.ExtendScore + " x 100";
        Score.GetComponent<Text>().text = "Score: " + GlobalScore.CurrentScore;

        timeCalc = GlobalTimer.ExtendScore * 100;
        totalScore = GlobalScore.CurrentScore + timeCalc;

        TotalScore.GetComponent<Text>().text = "Total Score: " + totalScore;

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
        yield return new WaitForSeconds(2);

        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2);

        GlobalScore.CurrentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.NextLevel);
    }
}
