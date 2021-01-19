using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject YouFellText;
    public GameObject LevelAudio;
    public GameObject FadeOut;

    void OnTriggerEnter()
    {
        StartCoroutine(HandleDeath());
    }

    IEnumerator HandleDeath()
    {
        YouFellText.SetActive(true);
        LevelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
