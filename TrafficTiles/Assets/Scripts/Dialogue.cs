using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject spawnTiles;
    public GameObject cycleTiles;

    public Image arrow1; // Points to bottom tile in column 1.
    public Image arrow2; // Points to bottom tile in column 2.
    public Image arrow3; // Points to bottom tile in column 3.
    public Image arrow4; // Points to bottom tile in column 4.
    public Image arrowRow1; // Points to row 1.
    public Image arrowRow2; // Points to row 2.
    public Image arrowScore; // Points to playerScoreText.
    public Image arrowTimer; // Points to timer.

    public Slider timer; // Timer in canvas.
    
    public Text dialogueText;
    public Text playerScoreText;

    public string[] dialogue;

    public float textSpeed;

    private int index;
    
    void Start()
    {
        timer.gameObject.SetActive(false);
        playerScoreText.gameObject.SetActive(false);
        arrow1.gameObject.SetActive(false);
        arrow2.gameObject.SetActive(false);
        arrow3.gameObject.SetActive(false);
        arrow4.gameObject.SetActive(false);
        arrowRow1.gameObject.SetActive(false);
        arrowRow2.gameObject.SetActive(false);
        arrowScore.gameObject.SetActive(false);
        arrowTimer.gameObject.SetActive(false);

        dialogueText.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            if (dialogueText.text == dialogue[index])
            {
                NextLine();
            }

            else
            {
                StopAllCoroutines();
                dialogueText.text = dialogue[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeDialogue());
    }

    IEnumerator TypeDialogue()
    {
        foreach (char c in dialogue[index].ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine()
    {
        if (index < dialogue.Length - 1)
        {
            index++;

            if (index == 1)
            {
                Vector2 spawnpoint = new Vector2(0, 0);
                Instantiate(spawnTiles, spawnpoint, Quaternion.identity);
                Instantiate(cycleTiles, spawnpoint, Quaternion.identity);

                timer.gameObject.SetActive(true);
                playerScoreText.gameObject.SetActive(true);
            }

            if (index == 2)
            {
                arrow1.gameObject.SetActive(true);
                arrow2.gameObject.SetActive(true);
                arrow3.gameObject.SetActive(true);
                arrow4.gameObject.SetActive(true);
            }

            if (index == 3)
            {
                arrow1.gameObject.SetActive(false);
                arrow2.gameObject.SetActive(false);
                arrow3.gameObject.SetActive(false);
                arrow4.gameObject.SetActive(false);
            }

            if (index == 4)
            {
                arrow1.gameObject.SetActive(true);
                arrow2.gameObject.SetActive(true);

                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableA = true;
            }

            if (index == 5)
            {
                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableA = false;

                arrow1.gameObject.SetActive(false);
                arrow2.gameObject.SetActive(false);
                arrow3.gameObject.SetActive(true);
                arrow4.gameObject.SetActive(true);

                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableD = true;
            }

            if (index == 6)
            {
                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableD = false;

                arrow3.gameObject.SetActive(false);
                arrow4.gameObject.SetActive(false);
            }

            if (index == 7)
            {
                arrow1.gameObject.SetActive(true);
                arrow2.gameObject.SetActive(true);
                arrow3.gameObject.SetActive(true);

                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableW = true;
            }

            if (index == 8)
            {
                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableW = false;

                arrow1.gameObject.SetActive(false);
                arrow4.gameObject.SetActive(true);

                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableS = true;

            }

            if (index == 9)
            {
                arrow2.gameObject.SetActive(false);
                arrow3.gameObject.SetActive(false);
                arrow4.gameObject.SetActive(false);

                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableA = true;
                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableD = true;
                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableW = true;
                GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableMoveColumns = true;
            }

            if (index >= 10)
            {
                if (GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().moveColumnsAmount == 0)
                {
                    index = 9;
                }

                else
                {
                    if (index == 9)
                    {
                        index = 10;
                    }
                }

                if (index == 11)
                {
                    arrowRow1.gameObject.SetActive(false);
                    arrowRow2.gameObject.SetActive(false);
                        
                    arrowScore.gameObject.SetActive(true);
                }

                if (index == 12)
                {
                    arrowScore.gameObject.SetActive(false);

                    arrowTimer.gameObject.SetActive(true);
                }

                if (index == 14)
                {
                    GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer_Tutorial>().enableTimer = true;
                }

                if (index >= 15)
                {
                    if (GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer_Tutorial>().timerEmptyAmount == 0)
                    {
                        index = 14;
                    }

                    else
                    {
                        if (index == 14)
                        {
                            index = 15;
                        }
                    }

                    if (index == 16)
                    {
                        GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableA = true;
                        GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableD = true;
                        GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableW = true;
                        GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableS = true;
                        GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableMoveColumns = true;
                    }

                    if (index >= 17)
                    {
                        if (GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().moveColumnsAmount <= 1)
                        {
                            index = 16;
                        }

                        else
                        {
                            if (index == 16)
                            {
                                index = 17;
                            }
                        }
                    }

                    if (index == 17)
                    {
                        GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer_Tutorial>().enableTimer = true;
                    }

                    if (index == 18)
                    {
                        GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableA = true;
                        GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableD = true;
                        GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableW = true;
                        GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableS = true;
                        GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().enableMoveColumns = true;
                    }

                    if (index >= 19)
                    {
                        if (GameObject.FindGameObjectWithTag("Cycle").GetComponent<CycleTiles_Tutorial>().moveColumnsAmount <= 4)
                        {
                            index = 18;
                        }
                    }

                    if (index == 19)
                    {
                        GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer_Tutorial>().enableTimer = false;
                    }

                    //if (index == 21)
                }
            }
            
            dialogueText.text = string.Empty;
            StartCoroutine(TypeDialogue());
        }

        else
        {
            gameObject.SetActive(false);
        }
    }
}
