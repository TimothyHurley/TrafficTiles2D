using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject spawnTiles;
    public GameObject cycleTiles;

    public Image arrow1;
    public Image arrow2;
    public Image arrow3;
    public Image arrow4;

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

    void NextLine()
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
