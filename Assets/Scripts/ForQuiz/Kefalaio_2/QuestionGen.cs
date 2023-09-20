using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGen : MonoBehaviour
{
    public static string actualAnswer2;
    public static bool displayingQuestion2 = false;

    public int questionNumber2; // Αρχικοποιήστε τον αριθμό της πρώτης ερώτησης.
    public int totalQuestions2 = 13; // Ολικός αριθμός ερωτήσεων.
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

                    QuestionDis.newQuestion2 = "H έκφραση if(z) είναι ισοδύναμη με την if(z != 0)";
                    QuestionDis.newA2 = "Α. Σωστό";
                    QuestionDis.newB2 = "Β. Λαθος";
                    QuestionDis.newC2 = "Γ. Μη έγκυρη έκφραση";
                    QuestionDis.newD2 = "Δ. Τίποτα απο τα δύο";
                    actualAnswer2 = "Α";
                }

                if (questionNumber2 == 2)
                {
                    QuestionDis.newQuestion2 = "H έκφραση if(!z) δεν είναι ισοδύναμη με την if(z == 0)";
                    QuestionDis.newA2 = "Α. Σωστό";
                    QuestionDis.newB2 = "Β. Λάθος";
                    QuestionDis.newC2 = "Γ. Μη έγκυρη έκφραση";
                    QuestionDis.newD2 = "Δ. Τίποτα απο τα παραπάνω";
                    actualAnswer2 = "Β";
                }

                if (questionNumber2 == 3)
                {
                    QuestionDis.newQuestion2 = "Ποιά είναι η έξοδος του προγράμματος;\r\n#inlcude <stdio.h>\r\nint main() {\r\n\tint i = 0;\r\n\tif (i = 0) {\r\n\t\tprintf(\"i equals to zero!\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "Α. i = 0";
                    QuestionDis.newB2 = "Β. 0 equals to zero";
                    QuestionDis.newC2 = "Γ. i equals to zero";
                    QuestionDis.newD2 = "Δ. το πρόγραμμα δεν θα εμφανίσει τίποτα";
                    actualAnswer2 = "Δ";
                }

                if (questionNumber2 == 4)
                {
                    QuestionDis.newQuestion2 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος;\r\n\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 0;\r\n\tif (x = 0) {\r\n\t\tprintf(\"x equals to zero\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"x  EQUALS TO ZERO\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "Α. x equals to zero";
                    QuestionDis.newB2 = "Β. 0 equals to zero";
                    QuestionDis.newC2 = "Γ. x EQUALS TO ZERO";
                    QuestionDis.newD2 = "Δ. το πρόγραμμα δεν θα εμφανίσει τίποτα";
                    actualAnswer2 = "Γ";
                }

                if (questionNumber2 == 5)
                {
                    QuestionDis.newQuestion2 = "Ποιά θα είναι η συνθήκη στην  if εαν θέλουμε να εμφανίσουμε την απόλυτη τιμή ενός ακέραιου αριθμού;\r\n#include <stdio.h>\r\nint main() {\r\n\tint number;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d\", &number);\r\n\t\r\n\tif(....... ) {\r\n\t\tprintf(\"The absolute value is %d\\n\", number);\r\n\t}\r\n\telse {\r\n\t\tprintf(\"The absolute value is %d\\n\", -number);\r\n\t}\r\n\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "Α. number >= 0";
                    QuestionDis.newB2 = "Β. number <= 0";
                    QuestionDis.newC2 = "Γ. number == 0";
                    QuestionDis.newD2 = "Δ. number != 0";
                    actualAnswer2 = "Α";
                }

                if (questionNumber2 == 6)
                {
                    QuestionDis.newQuestion2 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 1, y = 2;\r\n\tif (x && x/y) {\r\n\t\tprintf(\"Yes\\n\"); \r\n\t}\r\n\telse {\r\n\t\tprintf(\"No\\n\"); \r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "Α. Yes";
                    QuestionDis.newB2 = "Β. Yes\nNo";
                    QuestionDis.newC2 = "Γ. Τίποτα γιατί είναι λάθος η συνθήκη.";
                    QuestionDis.newD2 = "Δ. No";
                    actualAnswer2 = "Δ";
                }

                if (questionNumber2 == 7)
                {
                    QuestionDis.newQuestion2 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat i = 1.2;\r\n\r\n\tif(i == 1.2) {\r\n\t\tprintf(\"Yes\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"No\\n\");\t\r\n\r\n\treturn 0;\r\n}\r\n";
                    QuestionDis.newA2 = "Α. Yes";
                    QuestionDis.newB2 = "Β. No";
                    QuestionDis.newC2 = "Γ. Τίποτα γιατί η συνθήκη είναι λάθος.";
                    QuestionDis.newD2 = "Δ. Τίποτα απο τα παραπάνω.";
                    actualAnswer2 = "Β";
                }

                if (questionNumber2 == 8)
                {
                    QuestionDis.newQuestion2 = "Ποια είναι η έξοδος του προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x, y;\r\n\tx = y = 19;\r\n\tif(++x == y++) {\r\n\t\tprintf(\"One\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"Two\\n\");\r\n\t}\r\n\tprintf(\"%d %d\\n\", x, y);\t\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "Α. One \r\n 20 20";
                    QuestionDis.newB2 = "Β. Two\r\n 19 20";
                    QuestionDis.newC2 = "Γ. Two\r\n 20 19";
                    QuestionDis.newD2 = "Δ. Two\r\n 20 20";
                    actualAnswer2 = "Δ";
                }

                if (questionNumber2 == 9)
                {
                    QuestionDis.newQuestion2 = "Ποιά είναι η έξοδος του προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 2, y = 5, z = 3;\r\n\tif (x < y < z) {\r\n\t\tprintf(\"One\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"Two\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "Α. Two";
                    QuestionDis.newB2 = "Β. One";
                    QuestionDis.newC2 = "Γ. Τίποτα η συνθήκη είναι λάθος.";
                    QuestionDis.newD2 = "Δ. Τίποτα απο τα παραπάνω.";
                    actualAnswer2 = "Β";
                }

                if (questionNumber2 == 10)
                {
                    QuestionDis.newQuestion2 = "Ποιά είναι η έξοδος του παραπάνω προγράμματος αν το number είναι 12;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d, &number\");\r\n\t(x > 10) ? printf(\"One\\n\"); : printf(\"Two\\n\");\t\r\n\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "Α. x > 10";
                    QuestionDis.newB2 = "Β. Two";
                    QuestionDis.newC2 = "Γ. One";
                    QuestionDis.newD2 = "Δ. τίποτα απο τα παραπάνω";
                    actualAnswer2 = "Γ";
                }

                if (questionNumber2 == 11)
                {
                    QuestionDis.newQuestion2 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint i = 1;\r\n\tswitch(i) {\r\n\t\tcase 1:\r\n\t\t\tprintf(\"One\\n\");\r\n\t\treturn 0;\r\n\t\tcase 2:\r\n\t\t\tprintf(\"Two\\n\");\r\n\t\tbreak;\t\t}\r\n\t}\r\n\tprintf(\"End\\n\");\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "Α. One\r\nEnd";
                    QuestionDis.newB2 = "Β. One End";
                    QuestionDis.newC2 = "Γ. Two\r\nEnd";
                    QuestionDis.newD2 = "Δ. One";
                    actualAnswer2 = "Δ";
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
