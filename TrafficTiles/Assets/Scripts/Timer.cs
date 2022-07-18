using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider timer; // Timer in canvas.

    public float maxTime = 10f; // Maximum value of timer.
    public float remainingTime = 10f; // Current value of timer. Starts equal to maxTime.
    public float addTime = 7f; // Value added to timer.


    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            timer.value = remainingTime / maxTime;
        }

        else
        {
            GameObject.FindGameObjectWithTag("Scene").GetComponent<SceneManagement>().LoadEndMenuScene();
        }
    }

    public void IncreaseTimerValue()
    {
        remainingTime = remainingTime + addTime;

        if (remainingTime > maxTime)
        {
            remainingTime = maxTime;
        }
    }

    public void ReduceMaxTime()
    {
        maxTime = maxTime - 1f;
        Debug.Log("maxTime = " + maxTime);
    }
}
