using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text playerScoreText;

    public int playerScore = 0;

    void Start()
    {
        playerScoreText.text = ("" + playerScore);
    }
    
    public void IncreasePlayerScore()
    {
        playerScore++;
        playerScoreText.text = ("" + playerScore);

        if (playerScore == 5)
        {
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().ReduceMaxTime();
        }

        if (playerScore == 15)
        {
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().ReduceMaxTime();
        }

        if (playerScore == 25)
        {
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().ReduceMaxTime();
        }

        if (playerScore == 35)
        {
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().ReduceMaxTime();
        }

        if (playerScore == 45)
        {
            GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().ReduceMaxTime();
        }
    }
}
