using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;


    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            QuestionDisplay.newQuestion = " How many planets do we have?";
            QuestionDisplay.newA = "A. 12 planets";
            QuestionDisplay.newB = "B. 2 planets";
            QuestionDisplay.newC = "C. 100 planets";
            QuestionDisplay.newD = "D. 8 planets";
            actualAnswer = "D";
        }
    }
}
