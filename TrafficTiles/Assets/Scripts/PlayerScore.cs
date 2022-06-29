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
    }
}
