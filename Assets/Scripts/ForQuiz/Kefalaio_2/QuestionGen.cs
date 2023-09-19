using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGen : MonoBehaviour
{
    public static string actualAnswer2;
    public static bool displayingQuestion2 = false;

    public int questionNumber2; // Αρχικοποιήστε τον αριθμό της πρώτης ερώτησης.
    public int totalQuestions2 = 16; // Ολικός αριθμός ερωτήσεων.
    private bool quizCompleted2 = false; // Μεταβλητή που υποδεικνύει αν ολοκληρώθηκε το κουίζ.

    public AnswerBtn answerButtons2;


    void Start() // Χρησιμοποιήστε τη μέθοδο Start για την αρχικοποίηση.
    {
        displayingQuestion2 = false; // Κάντε την ψευδή όταν ξεκινά η σκηνή.
        questionNumber2 = 1; // Αρχικοποιήστε τον αριθμό της πρώτης ερώτησης.
    }



    void Update()
    {
        if (!quizCompleted2)
        {
            if (!displayingQuestion2)
            {
                displayingQuestion2 = true;

                //questionNumber = Random.Range(1, 5);
                if (questionNumber2 == 1)
                {

                    QuestionDis.newQuestion2 = "Ποια απο τις παρακάτω εντολές τυπώνει το \"Hello World!\" στην οθόνη;";
                    QuestionDis.newA2 = "Α. print(\"Hello World\");";
                    QuestionDis.newB2 = "Β. printf(\"Hello World!\");";
                    QuestionDis.newC2 = "Γ. printf(\"Hello World!\")";
                    QuestionDis.newD2 = "Δ. printf(Hello World!);";
                    actualAnswer2 = "Β";
                }

                if (questionNumber2 == 2)
                {
                    QuestionDis.newQuestion2 = "Ποιον τύπο δεδομένων χρησιμοποιούμε για την δήλωση ακεραίων μεταβλητών;";
                    QuestionDis.newA2 = "Α. char";
                    QuestionDis.newB2 = "Β. float";
                    QuestionDis.newC2 = "Γ. int";
                    QuestionDis.newD2 = "Δ. double";
                    actualAnswer2 = "Γ";
                }

                if (questionNumber2 == 3)
                {
                    QuestionDis.newQuestion2 = "Ποιον τύπο δεδομένων χρησιμοποιούμε για την δήλωση πραγματικών μεταβλητων;";
                    QuestionDis.newA2 = "Α. char";
                    QuestionDis.newB2 = "Β. float";
                    QuestionDis.newC2 = "Γ. int";
                    QuestionDis.newD2 = "Δ. κανένα απο τα παραπάνω";
                    actualAnswer2 = "Β";
                }

                if (questionNumber2 == 4)
                {
                    QuestionDis.newQuestion2 = "Ποια ακολουθία διαφυγής χρησιμοποιούμε για να αλλάξουμε γραμμή;";
                    QuestionDis.newA2 = "Α. \\n";
                    QuestionDis.newB2 = "Β. \\b";
                    QuestionDis.newC2 = "Γ. \\t";
                    QuestionDis.newD2 = "Δ. \\\"";
                    actualAnswer2 = "Α";
                }

                if (questionNumber2 == 5)
                {
                    QuestionDis.newQuestion2 = "Ποια απο τις παρακάτω εντολές διαβάζει έναν ακέραιο αριθμό και τον αποθηκεύει στην μεταβλητη i;";
                    QuestionDis.newA2 = "Α. scanf(\"%d\",&i)";
                    QuestionDis.newB2 = "Β. scan(\"%d\", &i);";
                    QuestionDis.newC2 = "Γ. scanf(\"%f\", &i);";
                    QuestionDis.newD2 = "Δ. scanf(\"%d\", &i);";
                    actualAnswer2 = "Δ";
                }

                if (questionNumber2 == 6)
                {
                    QuestionDis.newQuestion2 = "Ποια απο τις παρακάτω εντολές δηλώνει έναν πραγματικό αριθμό;";
                    QuestionDis.newA2 = "Α. float i";
                    QuestionDis.newB2 = "Β. int i";
                    QuestionDis.newC2 = "Γ. float i;";
                    QuestionDis.newD2 = "Δ. int i;";
                    actualAnswer2 = "Γ";
                }

                if (questionNumber2 == 7)
                {
                    QuestionDis.newQuestion2 = "Ποια απο τις παρακάτω εντολές δηλώνει μια μεταβλητή ως σταθερα;";
                    QuestionDis.newA2 = "Α. int x;";
                    QuestionDis.newB2 = "Β. const int x;";
                    QuestionDis.newC2 = "Γ. const x = 5;";
                    QuestionDis.newD2 = "Δ. const int x = 5;";
                    actualAnswer2 = "Δ";
                }

                if (questionNumber2 == 8)
                {
                    QuestionDis.newQuestion2 = "Ποιές απο τις παρακάτω εντολές δηλώνει μια μακροεντολή;";
                    QuestionDis.newA2 = "Α. #define SIZE 100;";
                    QuestionDis.newB2 = "Β. #define SIZE;";
                    QuestionDis.newC2 = "Γ. #define SIZE 100";
                    QuestionDis.newD2 = "Δ. #define SIZE";
                    actualAnswer2 = "Γ";
                }

                if (questionNumber2 == 9)
                {
                    QuestionDis.newQuestion2 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος; \r\n #include <stdio.h>\r\nint main () {\r\n\tprintf(\"Hello\\n\");\r\n\tprintf(\"World\");\r\n\treturn 0;\r\n};";
                    QuestionDis.newA2 = "Α. Hello\r\n   World";
                    QuestionDis.newB2 = "Β. Hello World";
                    QuestionDis.newC2 = "Γ. Hello\tworld";
                    QuestionDis.newD2 = "Δ. \"Hello\" \"World\"";
                    actualAnswer2 = "Α";
                }

                if (questionNumber2 == 10)
                {
                    QuestionDis.newQuestion2 = "Ποια είναι η έξοδος του παρακάτω προγράμματος;\r\n#inlude <stdio.h>\r\nint main() {\r\n\tint x = 20, y = 10;\r\n\tprintf(\"%d + %d = %d\\n\", x, y, x + y);\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "Α. %d + %d = %d";
                    QuestionDis.newB2 = "Β. x + y = x + y";
                    QuestionDis.newC2 = "Γ. 20 + 10 = 30";
                    QuestionDis.newD2 = "Δ. x + y = 30";
                    actualAnswer2 = "Γ";
                }

                if (questionNumber2 == 11)
                {
                    QuestionDis.newQuestion2 = "Ποια η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat x = 1.2365;\r\n\tprintf(\"Value = %f\\n\", x);\r\n\tprintf(\"Value = %.2f\\n\", x);\r\n\tprintf(\"Value = %.*f\\n\", 3, x);\r\n\tprintf(\"Value = %.f\\n\", x);\r\n\treturn 0;\r\n};";
                    QuestionDis.newA2 = "Α. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 1;";
                    QuestionDis.newB2 = "Β. Value = 1.2365\r  Value = 1.24\r\n  Value = 1.23\r\t   Value = 0.1";
                    QuestionDis.newC2 = "Γ. Value = 1.236500\r   Value = 1.24\r\n  Value = 1.23\r\t   Value = 1";
                    QuestionDis.newD2 = "Δ. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 0.1";
                    actualAnswer2 = "Α";
                }

                if (questionNumber2 == 12)
                {
                    QuestionDis.newQuestion2 = "Ποιός απο τους παρακάτω τελεστές χρησιμοποιείται για την εκχώρηση τιμής σε μία μεταβλητή;";
                    QuestionDis.newA2 = "Α. ->";
                    QuestionDis.newB2 = "Β. <-";
                    QuestionDis.newC2 = "Γ. =";
                    QuestionDis.newD2 = "Δ. ==";
                    actualAnswer2 = "Γ";
                }

                if (questionNumber2 == 13)
                {
                    QuestionDis.newQuestion2 = "Ποιό θα είναι το αποτέλεσμα της πράξης 3/2 αν και οι δύο αριθμοί είναι ακέραιοι;";
                    QuestionDis.newA2 = "Α. 1.5";
                    QuestionDis.newB2 = "Β. 1.0";
                    QuestionDis.newC2 = "Γ. 1";
                    QuestionDis.newD2 = "Δ. τίποτα απο τα παραπάνω";
                    actualAnswer2 = "Γ";
                }

                if (questionNumber2 == 14)
                {
                    QuestionDis.newQuestion2 = "Ποιά θα είναι η έξοδος του παρακάτω προγράμματος ;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\tx++;\r\n\tprintf(\"%d\\n\", x);\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "Α. 5";
                    QuestionDis.newB2 = "Β. 6";
                    QuestionDis.newC2 = "Γ. 7";
                    QuestionDis.newD2 = "Δ. x++";
                    actualAnswer2 = "Β";
                }

                if (questionNumber2 > totalQuestions2)
                {
                    quizCompleted2 = true;
                }
                /*  if (questionNumber > 4)
                  {
                      questionNumber = 1;
                  } */

                // all question go above this line
                QuestionDis.pleaseUpdate = false;
                questionNumber2++;

                if (questionNumber2 == totalQuestions2)
                {
                    answerButtons2.EndQuiz();
                }
            }

        }

    }
}
