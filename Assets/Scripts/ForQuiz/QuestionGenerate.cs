using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;

    public int questionNumber; // Αρχικοποιήστε τον αριθμό της πρώτης ερώτησης.
    public int totalQuestions = 16; // Ολικός αριθμός ερωτήσεων.
    private bool quizCompleted = false; // Μεταβλητή που υποδεικνύει αν ολοκληρώθηκε το κουίζ.

    public AnswerButtons answerButtons;


    void Start() // Χρησιμοποιήστε τη μέθοδο Start για την αρχικοποίηση.
    {
        displayingQuestion = false; // Κάντε την ψευδή όταν ξεκινά η σκηνή.
        questionNumber = 1; // Αρχικοποιήστε τον αριθμό της πρώτης ερώτησης.
    }

   

    void Update()
    {
        if (!quizCompleted)
        {
            if (!displayingQuestion)
            {
                displayingQuestion = true;

                //questionNumber = Random.Range(1, 5);
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

                if (questionNumber == 5)
                {
                    QuestionDisplay.newQuestion = "Ποια απο τις παρακάτω εντολές διαβάζει έναν ακέραιο αριθμό και τον αποθηκεύει στην μεταβλητη i;";
                    QuestionDisplay.newA = "Α. scanf(\"%d\",&i)";
                    QuestionDisplay.newB = "Β. scan(\"%d\", &i);";
                    QuestionDisplay.newC = "Γ. scanf(\"%f\", &i);";
                    QuestionDisplay.newD = "Δ. scanf(\"%d\", &i);";
                    actualAnswer = "Δ";
                }

                if (questionNumber == 6)
                {
                    QuestionDisplay.newQuestion = "Ποια απο τις παρακάτω εντολές δηλώνει έναν πραγματικό αριθμό;";
                    QuestionDisplay.newA = "Α. float i";
                    QuestionDisplay.newB = "Β. int i;";
                    QuestionDisplay.newC = "Γ. float i;";
                    QuestionDisplay.newD = "Δ. int i;";
                    actualAnswer = "Γ";
                }

                if (questionNumber == 7)
                {
                    QuestionDisplay.newQuestion = "Ποια απο τις παρακάτω εντολές δηλώνει μια μεταβλητή ως σταθερα;";
                    QuestionDisplay.newA = "Α. int x;";
                    QuestionDisplay.newB = "Β. const int x;";
                    QuestionDisplay.newC = "Γ. const x = 5;";
                    QuestionDisplay.newD = "Δ. const int x = 5;";
                    actualAnswer = "Δ";
                }

                if (questionNumber == 8)
                {
                    QuestionDisplay.newQuestion = "Ποιές απο τις παρακάτω εντολές δηλώνει μια μακροεντολή;";
                    QuestionDisplay.newA = "Α. #define SIZE 100;";
                    QuestionDisplay.newB = "Β. #define SIZE;";
                    QuestionDisplay.newC = "Γ. #define SIZE 100";
                    QuestionDisplay.newD = "Δ. #define SIZE";
                    actualAnswer = "Γ";
                }

                if (questionNumber == 9)
                {
                    QuestionDisplay.newQuestion = "Ποιά είναι η έξοδος του παρακάτω προγράμματος; \r\n #include <stdio.h>\r\nint main () {\r\n\tprintf(\"Hello\\n\");\r\n\tprintf(\"World\");\r\n\treturn 0;\r\n};";
                    QuestionDisplay.newA = "Α. Hello\r\n   World";
                    QuestionDisplay.newB = "Β. Hello World";
                    QuestionDisplay.newC = "Γ. Hello\tworld";
                    QuestionDisplay.newD = "Δ. \"Hello\" \"World\"";
                    actualAnswer = "Α";
                }

                if (questionNumber == 10)
                {
                    QuestionDisplay.newQuestion = "Ποια είναι η έξοδος του παρακάτω προγράμματος;\r\n#inlude <stdio.h>\r\nint main() {\r\n\tint x = 20, y = 10;\r\n\tprintf(\"%d + %d = %d\\n\", x, y, x + y);\r\n\treturn 0;\r\n}";
                    QuestionDisplay.newA = "Α. %d + %d = %d";
                    QuestionDisplay.newB = "Β. x + y = x + y";
                    QuestionDisplay.newC = "Γ. 20 + 10 = 30";
                    QuestionDisplay.newD = "Δ. x + y = 30";
                    actualAnswer = "Γ";
                }

                if (questionNumber == 11)
                {
                    QuestionDisplay.newQuestion = "Ποια η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat x = 1.2365;\r\n\tprintf(\"Value = %f\\n\", x);\r\n\tprintf(\"Value = %.2f\\n\", x);\r\n\tprintf(\"Value = %.*f\\n\", 3, x);\r\n\tprintf(\"Value = %.f\\n\", x);\r\n\treturn 0;\r\n};";
                    QuestionDisplay.newA = "Α. Value = 1.236500\r\n   Value = 1.24\r\t   Value = 1.237\r\n   Value = 1;";
                    QuestionDisplay.newB = "Β. Value = 1.2365\r\n   Value = 1.24\r\t   Value = 1.23\r\n   Value = 0.1";
                    QuestionDisplay.newC = "Γ. Value = 1.236500\r\n   Value = 1.24\r\t  Value = 1.23\r\n   Value = 1";
                    QuestionDisplay.newD = "Δ. Value = 1.236500\r\n   Value = 1.24\r\t   Value = 1.237\r\n   Value = 0.1";
                    actualAnswer = "Α";
                }

                if (questionNumber == 12)
                {
                    QuestionDisplay.newQuestion = "Ποιός απο τους παρακάτω τελεστές χρησιμοποιείται για την εκχώρηση τιμής σε μία μεταβλητή;";
                    QuestionDisplay.newA = "Α. ->";
                    QuestionDisplay.newB = "Β. <-";
                    QuestionDisplay.newC = "Γ. =";
                    QuestionDisplay.newD = "Δ. ==";
                    actualAnswer = "Γ";
                }

                if (questionNumber == 13)
                {
                    QuestionDisplay.newQuestion = "Ποιό θα είναι το αποτέλεσμα της πράξης 3/2 αν και οι δύο αριθμοί είναι ακέραιοι;";
                    QuestionDisplay.newA = "Α. 1.5";
                    QuestionDisplay.newB = "Β. 1.0";
                    QuestionDisplay.newC = "Γ. 1";
                    QuestionDisplay.newD = "Δ. τίποτα απο τα παραπάνω";
                    actualAnswer = "Γ";
                }

                if (questionNumber == 14)
                {
                    QuestionDisplay.newQuestion = "Ποιά θα είναι η έξοδος του παρακάτω προγράμματος ;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\tx++;\r\n\tprintf(\"%d\\n\", x);\r\n\treturn 0;\r\n}";
                    QuestionDisplay.newA = "Α. 5";
                    QuestionDisplay.newB = "Β. 6";
                    QuestionDisplay.newC = "Γ. 7";
                    QuestionDisplay.newD = "Δ. x++";
                    actualAnswer = "Β";
                }

                if (questionNumber > totalQuestions)
                {
                    quizCompleted = true;
                }
                /*  if (questionNumber > 4)
                  {
                      questionNumber = 1;
                  } */
               
                // all question go above this line
                QuestionDisplay.pleaseUpdate = false;
                questionNumber++;

                if(questionNumber == totalQuestions)
                {
                    answerButtons.EndQuiz();
                }
            } 
           
        }
       
    }
}
