using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int DestinationLevel = 1;

    void Update()
    {
        if(DestinationLevel == 1)
        {
            SceneManager.LoadScene(DestinationLevel);
        }
    }
}
