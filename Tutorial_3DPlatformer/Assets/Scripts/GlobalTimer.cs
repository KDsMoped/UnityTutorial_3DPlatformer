using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject TimeDisplay01;
    public GameObject TimeDisplay02;

    private bool isTakingTime = false;
    private int seconds = 150;


    void Update()
    {
        if(isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        isTakingTime = true;

        seconds -= 1;
        TimeDisplay01.GetComponent<Text>().text = "" + seconds;
        TimeDisplay02.GetComponent<Text>().text = "" + seconds;

        yield return new WaitForSeconds(1);

        isTakingTime = false;
    }
}
