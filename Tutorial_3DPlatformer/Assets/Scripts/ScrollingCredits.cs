using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollingCredits : MonoBehaviour
{
    public GameObject Credits;

    void Start()
    {
        StartCoroutine(RollCredits());
    }

    IEnumerator RollCredits()
    {
        yield return new WaitForSeconds(0.5f);
        Credits.SetActive(true);
        yield return new WaitForSeconds(15.0f);
        SceneManager.LoadScene(1);
    }
}
