using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class girisEkranı : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue;
    public static int index;
    public GameObject contunieButton;
    public float wordSpeed;




    void Update()
    {       

        if (dialogueText.text == dialogue[index])
        {
            contunieButton.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                NextLine();
            }
        }


    }

    public void cleanText()
    {
        dialogueText.text = "";
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {

        contunieButton.SetActive(false);

        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            cleanText();
        }
    }

}
