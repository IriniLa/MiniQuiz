using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDis : MonoBehaviour
{
    public GameObject screenQuestion2;
    public GameObject answerA2;
    public GameObject answerB2;
    public GameObject answerC2;
    public GameObject answerD2;
    public static string newQuestion2;
    public static string newA2;
    public static string newB2;
    public static string newC2;
    public static string newD2;
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
        screenQuestion2.GetComponent<Text>().text = newQuestion2;
        answerA2.GetComponent<Text>().text = newA2;
        answerB2.GetComponent<Text>().text = newB2;
        answerC2.GetComponent<Text>().text = newC2;
        answerD2.GetComponent<Text>().text = newD2;
    }

}
