using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisp : MonoBehaviour
{
    public GameObject screenQuestion4;
    public GameObject answerA4;
    public GameObject answerB4;
    public GameObject answerC4;
    public GameObject answerD4;
    public static string newQuestion4;
    public static string newA4;
    public static string newB4;
    public static string newC4;
    public static string newD4;
    public static bool pleaseUpdate = false;


    void Update()
    {
        if (pleaseUpdate == false)
        {
            pleaseUpdate = true;
            StartCoroutine(PushTextOnScreen());
        }
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion4.GetComponent<Text>().text = newQuestion4;
        answerA4.GetComponent<Text>().text = newA4;
        answerB4.GetComponent<Text>().text = newB4;
        answerC4.GetComponent<Text>().text = newC4;
        answerD4.GetComponent<Text>().text = newD4;
    }

}