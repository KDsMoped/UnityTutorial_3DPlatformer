using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public AudioSource LevelMusic;
    public GameObject PauseMenu;

    private bool gamePaused = false;

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if (gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;

                LevelMusic.Pause();

                PauseMenu.SetActive(true);
                PauseMenu.SetActive(true);
            }
            else
            {
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;

                LevelMusic.UnPause();

                PauseMenu.SetActive(false);
            }
        }
    }
}
