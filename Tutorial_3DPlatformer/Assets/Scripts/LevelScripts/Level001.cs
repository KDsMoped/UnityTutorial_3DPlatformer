using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level001 : MonoBehaviour
{
    public GameObject FadeIn;

    void Start()
    {
        FadeIn.SetActive(true);
        RedirectToLevel.DestinationLevel = 3;
        StartCoroutine(FadeOnOff());
    }

    IEnumerator FadeOnOff()
    {
        yield return new WaitForSeconds(1);
        FadeIn.SetActive(false);
    }
}
