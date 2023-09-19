using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionG : MonoBehaviour
{
    public static string actualAnswer3;
    public static bool displayingQuestion3 = false;

    public int questionNumber3; // Αρχικοποιήστε τον αριθμό της πρώτης ερώτησης.
    public int totalQuestions3 = 16; // Ολικός αριθμός ερωτήσεων.
    private bool quizCompleted3 = false; // Μεταβλητή που υποδεικνύει αν ολοκληρώθηκε το κουίζ.

    public AnswerBt AnswerButtons3;


    void Start() // Χρησιμοποιήστε τη μέθοδο Start για την αρχικοποίηση.
    {
        displayingQuestion3 = false; // Κάντε την ψευδή όταν ξεκινά η σκηνή.
        questionNumber3 = 1; // Αρχικοποιήστε τον αριθμό της πρώτης ερώτησης.
    }



    void Update()
    {
        if (!quizCompleted3)
        {
            if (!displayingQuestion3)
            {
                displayingQuestion3 = true;

                //questionNumber = Random.Range(1, 5);
                if (questionNumber3 == 1)
                {

                    QuestionD.newQuestion3 = "Ποια απο τις παρακάτω εντολές τυπώνει το \"Hello World!\" στην οθόνη;";
                    QuestionD.newA3 = "Α. print(\"Hello World\");";
                    QuestionD.newB3 = "Β. printf(\"Hello World!\");";
                    QuestionD.newC3 = "Γ. printf(\"Hello World!\")";
                    QuestionD.newD3 = "Δ. printf(Hello World!);";
                    actualAnswer3 = "Β";
                }

                if (questionNumber3 == 2)
                {
                    QuestionD.newQuestion3 = "Ποιον τύπο δεδομένων χρησιμοποιούμε για την δήλωση ακεραίων μεταβλητών;";
                    QuestionD.newA3 = "Α. char";
                    QuestionD.newB3 = "Β. float";
                    QuestionD.newC3 = "Γ. int";
                    QuestionD.newD3 = "Δ. double";
                    actualAnswer3 = "Γ";
                }

                if (questionNumber3 == 3)
                {
                    QuestionD.newQuestion3 = "Ποιον τύπο δεδομένων χρησιμοποιούμε για την δήλωση πραγματικών μεταβλητων;";
                    QuestionD.newA3 = "Α. char";
                    QuestionD.newB3 = "Β. float";
                    QuestionD.newC3 = "Γ. int";
                    QuestionD.newD3 = "Δ. κανένα απο τα παραπάνω";
                    actualAnswer3 = "Β";
                }

                if (questionNumber3 == 4)
                {
                    QuestionD.newQuestion3 = "Ποια ακολουθία διαφυγής χρησιμοποιούμε για να αλλάξουμε γραμμή;";
                    QuestionD.newA3 = "Α. \\n";
                    QuestionD.newB3 = "Β. \\b";
                    QuestionD.newC3 = "Γ. \\t";
                    QuestionD.newD3 = "Δ. \\\"";
                    actualAnswer3 = "Α";
                }

                if (questionNumber3 == 5)
                {
                    QuestionD.newQuestion3 = "Ποια απο τις παρακάτω εντολές διαβάζει έναν ακέραιο αριθμό και τον αποθηκεύει στην μεταβλητη i;";
                    QuestionD.newA3 = "Α. scanf(\"%d\",&i)";
                    QuestionD.newB3 = "Β. scan(\"%d\", &i);";
                    QuestionD.newC3 = "Γ. scanf(\"%f\", &i);";
                    QuestionD.newD3 = "Δ. scanf(\"%d\", &i);";
                    actualAnswer3 = "Δ";
                }

                if (questionNumber3 == 6)
                {
                    QuestionD.newQuestion3 = "Ποια απο τις παρακάτω εντολές δηλώνει έναν πραγματικό αριθμό;";
                    QuestionD.newA3 = "Α. float i";
                    QuestionD.newB3 = "Β. int i";
                    QuestionD.newC3 = "Γ. float i;";
                    QuestionD.newD3 = "Δ. int i;";
                    actualAnswer3 = "Γ";
                }

                if (questionNumber3 == 7)
                {
                    QuestionD.newQuestion3 = "Ποια απο τις παρακάτω εντολές δηλώνει μια μεταβλητή ως σταθερα;";
                    QuestionD.newA3 = "Α. int x;";
                    QuestionD.newB3 = "Β. const int x;";
                    QuestionD.newC3 = "Γ. const x = 5;";
                    QuestionD.newD3 = "Δ. const int x = 5;";
                    actualAnswer3 = "Δ";
                }

                if (questionNumber3 == 8)
                {
                    QuestionD.newQuestion3 = "Ποιές απο τις παρακάτω εντολές δηλώνει μια μακροεντολή;";
                    QuestionD.newA3 = "Α. #define SIZE 100;";
                    QuestionD.newB3 = "Β. #define SIZE;";
                    QuestionD.newC3 = "Γ. #define SIZE 100";
                    QuestionD.newD3 = "Δ. #define SIZE";
                    actualAnswer3 = "Γ";
                }

                if (questionNumber3 == 9)
                {
                    QuestionD.newQuestion3 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος; \r\n #include <stdio.h>\r\nint main () {\r\n\tprintf(\"Hello\\n\");\r\n\tprintf(\"World\");\r\n\treturn 0;\r\n};";
                    QuestionD.newA3 = "Α. Hello\r\n   World";
                    QuestionD.newB3 = "Β. Hello World";
                    QuestionD.newC3 = "Γ. Hello\tworld";
                    QuestionD.newD3 = "Δ. \"Hello\" \"World\"";
                    actualAnswer3 = "Α";
                }

                if (questionNumber3 == 10)
                {
                    QuestionD.newQuestion3 = "Ποια είναι η έξοδος του παρακάτω προγράμματος;\r\n#inlude <stdio.h>\r\nint main() {\r\n\tint x = 20, y = 10;\r\n\tprintf(\"%d + %d = %d\\n\", x, y, x + y);\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "Α. %d + %d = %d";
                    QuestionD.newB3 = "Β. x + y = x + y";
                    QuestionD.newC3 = "Γ. 20 + 10 = 30";
                    QuestionD.newD3 = "Δ. x + y = 30";
                    actualAnswer3 = "Γ";
                }

                if (questionNumber3 == 11)
                {
                    QuestionD.newQuestion3 = "Ποια η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat x = 1.2365;\r\n\tprintf(\"Value = %f\\n\", x);\r\n\tprintf(\"Value = %.2f\\n\", x);\r\n\tprintf(\"Value = %.*f\\n\", 3, x);\r\n\tprintf(\"Value = %.f\\n\", x);\r\n\treturn 0;\r\n};";
                    QuestionD.newA3 = "Α. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 1;";
                    QuestionD.newB3 = "Β. Value = 1.2365\r  Value = 1.24\r\n  Value = 1.23\r\t   Value = 0.1";
                    QuestionD.newC3 = "Γ. Value = 1.236500\r   Value = 1.24\r\n  Value = 1.23\r\t   Value = 1";
                    QuestionD.newD3 = "Δ. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 0.1";
                    actualAnswer3 = "Α";
                }

                if (questionNumber3 == 12)
                {
                    QuestionD.newQuestion3 = "Ποιός απο τους παρακάτω τελεστές χρησιμοποιείται για την εκχώρηση τιμής σε μία μεταβλητή;";
                    QuestionD.newA3 = "Α. ->";
                    QuestionD.newB3 = "Β. <-";
                    QuestionD.newC3 = "Γ. =";
                    QuestionD.newD3 = "Δ. ==";
                    actualAnswer3 = "Γ";
                }

                if (questionNumber3 == 13)
                {
                    QuestionD.newQuestion3 = "Ποιό θα είναι το αποτέλεσμα της πράξης 3/2 αν και οι δύο αριθμοί είναι ακέραιοι;";
                    QuestionD.newA3 = "Α. 1.5";
                    QuestionD.newB3 = "Β. 1.0";
                    QuestionD.newC3 = "Γ. 1";
                    QuestionD.newD3 = "Δ. τίποτα απο τα παραπάνω";
                    actualAnswer3 = "Γ";
                }

                if (questionNumber3 == 14)
                {
                    QuestionD.newQuestion3 = "Ποιά θα είναι η έξοδος του παρακάτω προγράμματος ;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\tx++;\r\n\tprintf(\"%d\\n\", x);\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "Α. 5";
                    QuestionD.newB3 = "Β. 6";
                    QuestionD.newC3 = "Γ. 7";
                    QuestionD.newD3 = "Δ. x++";
                    actualAnswer3 = "Β";
                }

                if (questionNumber3 > totalQuestions3)
                {
                    quizCompleted3 = true;
                }
                /*  if (questionNumber > 4)
                  {
                      questionNumber = 1;
                  } */

                // all question go above this line
                QuestionD.pleaseUpdate = false;
                questionNumber3++;

                if (questionNumber3 == totalQuestions3)
                {
                    AnswerButtons3.EndQuiz();
                }
            }

        }

    }
}