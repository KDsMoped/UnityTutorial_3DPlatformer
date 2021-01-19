using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int DestinationLevel = 3;

    void Update()
    {
        if(DestinationLevel == 3)
        {
            SceneManager.LoadScene(DestinationLevel);
        }
    }
}
