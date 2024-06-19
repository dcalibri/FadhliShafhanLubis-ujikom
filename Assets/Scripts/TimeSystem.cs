using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Events;


public class TimeSystem : MonoBehaviour
{
    public float Time = 300f;
    
    public TextMeshProUGUI textTimer;

    public UnityEvent onTimeOut;

    void FixedUpdate()
    {
        Time-- ; //based on timerunitSystem

        if (Time == 0)
        {
            onTimeOut.Invoke();
        }

       
    }

}
