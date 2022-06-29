using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text tutorialText;

    int textValue;
    
    void Start()
    {
        textValue = 0;
        tutorialText.text = ("display text #" + textValue);
    }

    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            textValue++;
            tutorialText.text = ("display text #" + textValue);
        }
    }
}
