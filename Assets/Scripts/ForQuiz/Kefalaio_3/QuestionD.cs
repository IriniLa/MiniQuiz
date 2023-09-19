using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionD : MonoBehaviour
{
    public GameObject screenQuestion3;
    public GameObject answerA3;
    public GameObject answerB3;
    public GameObject answerC3;
    public GameObject answerD3;
    public static string newQuestion3;
    public static string newA3;
    public static string newB3;
    public static string newC3;
    public static string newD3;
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
        screenQuestion3.GetComponent<Text>().text = newQuestion3;
        answerA3.GetComponent<Text>().text = newA3;
        answerB3.GetComponent<Text>().text = newB3;
        answerC3.GetComponent<Text>().text = newC3;
        answerD3.GetComponent<Text>().text = newD3;
    }

}