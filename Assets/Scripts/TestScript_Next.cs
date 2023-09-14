using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript_Next : MonoBehaviour
{
    public Text textField;
    public string[] paragraphs;
    private int currentParagraphIndex = 0;

    private void Start()
    {
        textField.text = paragraphs[currentParagraphIndex];
    }

    public void NextParagraph()
    {
        currentParagraphIndex++;

        if (currentParagraphIndex < paragraphs.Length)
        {
            textField.text = paragraphs[currentParagraphIndex];
        }
        else
        {
            textField.text = "End of text."; // You can customize this message.
        }
    }
}
