using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource ButtonPress;
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
}
