using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHighScore : MonoBehaviour
{
    public Text highScoreText;
    
    public static int playerHighScore = 0;
    
    
    void Start()
    {
        if (PlayerScore.playerScore > playerHighScore)
        {
            playerHighScore = PlayerScore.playerScore;
        }

        highScoreText.text = ("High Score: " + playerHighScore);
    }
}
