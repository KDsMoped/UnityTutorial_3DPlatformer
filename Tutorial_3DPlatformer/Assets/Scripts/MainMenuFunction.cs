using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource ButtonPress;
    public GameObject BestScoreDisplay;

    public int bestScore;

    void Start()
    {
        updateBestScore();
    }

    public void PlayGame()
    {
        ButtonPress.Play();

        RedirectToLevel.DestinationLevel = 3;
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayCredits()
    {
        ButtonPress.Play();

        SceneManager.LoadScene(4);
    }

    public void ResetBest()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
        updateBestScore();
    }

    private void updateBestScore()
    {
        bestScore = PlayerPrefs.GetInt("LevelScore");
        BestScoreDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }
}
