using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    void Start()
    {
        Countdown();
    }

    void Countdown()
    {
        Debug.Log("Countdown started");
        for (int i = 10; i >= 0; i--)
        {
            Debug.Log(i);
        }
        Debug.Log("Blastoff");
    }
}


