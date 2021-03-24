using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public AudioSource LevelMusic;
    public AudioSource PauseJingle;
    public GameObject PauseMenu;

    private bool gamePaused = false;

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if (gamePaused == false)
            {
                PauseJingle.Play();

                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;

                LevelMusic.Pause();

                PauseMenu.SetActive(true);
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void ResumeGame()
    {
        Cursor.visible = false;
        unpause();
    }

    public void RestartLevel()
    {
        ResumeGame();
        SceneManager.LoadScene(2);
    }

    public void QuitToMenu()
    {
        unpause();
        SceneManager.LoadScene(1);
    }

    private void unpause()
    {
        gamePaused = false;
        Time.timeScale = 1;

        LevelMusic.UnPause();

        PauseMenu.SetActive(false);
    }
}
