using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;

    public int questionNumber;


    void Update()
    {
        if (displayingQuestion == false)
        {   
            displayingQuestion = true;
            questionNumber = Random.Range(1, 5);

            if (questionNumber == 1)
            {
                
                QuestionDisplay.newQuestion = "Ποια απο τις παρακάτω εντολές τυπώνει το \"Hello World!\" στην οθόνη;";
                QuestionDisplay.newA = "Α. print(\"Hello World\");";
                QuestionDisplay.newB = "Β. printf(\"Hello World!\");";
                QuestionDisplay.newC = "Γ. printf(\"Hello World!\")";
                QuestionDisplay.newD = "Δ. printf(Hello World!);";
                actualAnswer = "Β";
            }

            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Ποιον τύπο δεδομένων χρησιμοποιούμε για την δήλωση ακεραίων μεταβλητών;";
                QuestionDisplay.newA = "Α. char";
                QuestionDisplay.newB = "Β. float";
                QuestionDisplay.newC = "Γ. int";
                QuestionDisplay.newD = "Δ. double";
                actualAnswer = "Γ";
            }

            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Ποιον τύπο δεδομένων χρησιμοποιούμε για την δήλωση πραγματικών μεταβλητων;";
                QuestionDisplay.newA = "Α. char";
                QuestionDisplay.newB = "Β. float";
                QuestionDisplay.newC = "Γ. int";
                QuestionDisplay.newD = "Δ. κανένα απο τα παραπάνω";
                actualAnswer = "Β";
            }

            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Ποια ακολουθία διαφυγής χρησιμοποιούμε για να αλλάξουμε γραμμή;";
                QuestionDisplay.newA = "Α. \\n";
                QuestionDisplay.newB = "Β. \\b";
                QuestionDisplay.newC = "Γ. \\t";
                QuestionDisplay.newD = "Δ. \\\"";
                actualAnswer = "Α";
            }

            // all question go above this line
            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
