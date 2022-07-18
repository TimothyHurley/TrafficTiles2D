using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public void LoadStartMenuScene()
    {
        SceneManager.LoadScene("StartMenuScene");
    }

    public void LoadTutorialScene()
    {
        PlayerScore.playerScore = 0;
        SceneManager.LoadScene("TutorialScene");
    }
    
    public void LoadEndMenuScene()
    {
        SceneManager.LoadScene("EndMenuScene");
    }

    public void LoadSampleScene()
    {
        PlayerScore.playerScore = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
