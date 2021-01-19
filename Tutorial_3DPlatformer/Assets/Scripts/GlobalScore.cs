using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject ScoreBox;
    public static int CurrentScore;
    public int InternalScore;

    void Update()
    {
        ScoreBox.GetComponent<Text>().text = "" + InternalScore;
        InternalScore = CurrentScore;
    }

}
