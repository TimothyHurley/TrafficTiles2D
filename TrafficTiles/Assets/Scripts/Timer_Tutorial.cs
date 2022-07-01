using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer_Tutorial : MonoBehaviour
{
    public Slider timer; // Timer in canvas.

    public bool enableTimer = false; // Enables timer when true.
    
    public float maxTime = 5f; // Maximum value of timer.
    public float remainingTime = 5f; // Current value of timer. Starts equal to maxTime.
    public float addTime = 3.5f; // Value added to timer.

    public int timerEmptyAmount = 0; // Number of times timer has depleted.


    void Update()
    {
        if (enableTimer == true)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
                timer.value = remainingTime / maxTime;
            }

            else
            {
                timerEmptyAmount++;
                if (timerEmptyAmount == 1)
                {
                    GameObject.FindGameObjectWithTag("Dialogue").GetComponent<Dialogue>().NextLine();
                    GameObject.FindGameObjectWithTag("Dialogue").GetComponent<Dialogue>().arrowTimer.gameObject.SetActive(false);
                }
            }
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
}
