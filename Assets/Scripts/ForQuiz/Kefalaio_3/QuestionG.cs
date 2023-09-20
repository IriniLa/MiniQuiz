using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionG : MonoBehaviour
{
    public static string actualAnswer3;
    public static bool displayingQuestion3 = false;

    public int questionNumber3; // Αρχικοποιήστε τον αριθμό της πρώτης ερώτησης.
    public int totalQuestions3 = 10; // Ολικός αριθμός ερωτήσεων.
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

                    QuestionD.newQuestion3 = "Τι θα πρέπει να γράψουμε μέσα στην for ωστε να εμφανίζει τους ακέραιους με αντίστροφη σειρά απο το 5 μέχρι το 1; # include <stdio.h>\r\nint main() {\r\n\tint i;\r\n\tfor(..........) {\r\n\t\tprintf(\"%d \");\t\r\n\t}\r\n\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "Α. (i = 1; i <= 5; i++)";
                    QuestionD.newB3 = "Β. (i = 5; i >= 1; i--)";
                    QuestionD.newC3 = "Γ. (i = 5; i >= 1; --i)";
                    QuestionD.newD3 = "Δ. (i = 1; i <= 5; ++i);";
                    actualAnswer3 = "Β";
                }

                if (questionNumber3 == 2)
                {
                    QuestionD.newQuestion3 = "Όταν ξέρουμε τον αριθμό των επαναλήψεων, ποιόν βρόχο επανάληψης προτιμάμε;";
                    QuestionD.newA3 = "Α. do-while";
                    QuestionD.newB3 = "Β. while";
                    QuestionD.newC3 = "Γ. if";
                    QuestionD.newD3 = "Δ. for";
                    actualAnswer3 = "Δ";
                }

                if (questionNumber3 == 3)
                {
                    QuestionD.newQuestion3 = "Όταν δεν ξέρουμε τον αριθμό των επαναλήψεων, ποιόν βρόχο επανάληψης προτιμάμε;";
                    QuestionD.newA3 = "Α. do-while";
                    QuestionD.newB3 = "Β. while";
                    QuestionD.newC3 = "Γ. if";
                    QuestionD.newD3 = "Δ. for";
                    actualAnswer3 = "Β";
                }

                if (questionNumber3 == 4)
                {
                    QuestionD.newQuestion3 = "Ποιός απο τους παρακάτω βρόχους επανάληψης εκτελείται τουλάχιστον μια φορά;";
                    QuestionD.newA3 = "Α. do-while";
                    QuestionD.newB3 = "Β. while";
                    QuestionD.newC3 = "Γ. if";
                    QuestionD.newD3 = "Δ. for";
                    actualAnswer3 = "Α";
                }

                if (questionNumber3 == 5)
                {
                    QuestionD.newQuestion3 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\twhile(x != 0) {\r\n\t\tprintf(\"%d \", x);\r\n\t\tx++;\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "Α. 0 1 2 3 4 5";
                    QuestionD.newB3 = "Β. 5 4 3 2 1 0";
                    QuestionD.newC3 = "Γ. 5 4 3 2 1";
                    QuestionD.newD3 = "Δ. 1 2 3 4 5";
                    actualAnswer3 = "Γ";
                }

                if (questionNumber3 == 6)
                {
                    QuestionD.newQuestion3 = "Πόσες φορές εκελείται ο while βρόχος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint a = 256, b = 4;\r\n\twhile(a != b) {\r\n\t\tb = b*b\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "Α. 3 φορές";
                    QuestionD.newB3 = "Β. 0 φορές";
                    QuestionD.newC3 = "Γ. 20 φορές";
                    QuestionD.newD3 = "Δ. 2 φορές";
                    actualAnswer3 = "Δ";
                }

                if (questionNumber3 == 7)
                {
                    QuestionD.newQuestion3 = "Ποιά συνθήκη πρέπει να προστεθεί στη εντολή while ώστε το πρόγραμμα να εμφανίσει τους αριθμούς απο το 1 μέχρι το 5;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 1;\r\n\tdo{\r\n\t\tprintf(\"%d\\n\", x);\r\n\t\tx++;\r\n\t} while(.......);\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "Α. i < 5";
                    QuestionD.newB3 = "Β. i <= 5";
                    QuestionD.newC3 = "Γ. i <= 5;";
                    QuestionD.newD3 = "Δ. i < 5;";
                    actualAnswer3 = "Β";
                }

                if (questionNumber3 == 8)
                {
                    QuestionD.newQuestion3 = "Συμπληρώστε τις εντολές ώστε τι πρόγραμμα να εμφανίζει την λέξη \"Correct\" τόσες φορές όσες και ο ακέραιος που θα δωθεί ως είσοδο.\r\n#include <stdio.h>\r\nint main() {\r\n\tint i, number;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d\", &number);\r\n\ti = 1;\r\n\tdo { ......\r\n\t} while(i <= number);\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "Α. printf(\"Correct\\n\");\r\n   i++";
                    QuestionD.newB3 = "Β. i++;";
                    QuestionD.newC3 = "Γ. printf(\"Correct\\n\");";
                    QuestionD.newD3 = "Δ. printf(\"Correct\\n\"); \r\n   i++;";
                    actualAnswer3 = "Δ";
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