using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
    public GameObject Ledge;
    public GameObject Player;

    void OnTriggerEnter()
    {
        Player.transform.parent = Ledge.transform;
    }

    void OnTriggerExit()
    {
        Player.transform.parent = null;
    }
}
