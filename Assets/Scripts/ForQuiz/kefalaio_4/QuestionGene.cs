using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGene : MonoBehaviour
{
    public static string actualAnswer4;
    public static bool displayingQuestion4 = false;

    public int questionNumber4; // Αρχικοποιήστε τον αριθμό της πρώτης ερώτησης.
    public int totalQuestions4 = 35; // Ολικός αριθμός ερωτήσεων.
    private bool quizCompleted4 = false; // Μεταβλητή που υποδεικνύει αν ολοκληρώθηκε το κουίζ.

    public AnswerBut AnswerButtons4;


    void Start() // Χρησιμοποιήστε τη μέθοδο Start για την αρχικοποίηση.
    {
        displayingQuestion4 = false; // Κάντε την ψευδή όταν ξεκινά η σκηνή.
        questionNumber4 = 1; // Αρχικοποιήστε τον αριθμό της πρώτης ερώτησης.
    }



    void Update()
    {
        if (!quizCompleted4)
        {
            if (!displayingQuestion4)
            {
                displayingQuestion4 = true;

                //questionNumber4 = Random.Range(1, 5);
                if (questionNumber4 == 1)
                {

                    QuestionDisp.newQuestion4 = "Ποια απο τις παρακάτω εντολές τυπώνει το \"Hello World!\" στην οθόνη;";
                    QuestionDisp.newA4 = "Α. print(\"Hello World\");";
                    QuestionDisp.newB4 = "Β. printf(\"Hello World!\");";
                    QuestionDisp.newC4 = "Γ. printf(\"Hello World!\")";
                    QuestionDisp.newD4 = "Δ. printf(Hello World!);";
                    actualAnswer4 = "Β";
                }

                if (questionNumber4 == 2)
                {
                    QuestionDisp.newQuestion4 = "Ποιον τύπο δεδομένων χρησιμοποιούμε για την δήλωση ακεραίων μεταβλητών;";
                    QuestionDisp.newA4 = "Α. char";
                    QuestionDisp.newB4 = "Β. float";
                    QuestionDisp.newC4 = "Γ. int";
                    QuestionDisp.newD4 = "Δ. double";
                    actualAnswer4 = "Γ";
                }

                if (questionNumber4 == 3)
                {
                    QuestionDisp.newQuestion4 = "Ποιον τύπο δεδομένων χρησιμοποιούμε για την δήλωση πραγματικών μεταβλητων;";
                    QuestionDisp.newA4 = "Α. char";
                    QuestionDisp.newB4 = "Β. float";
                    QuestionDisp.newC4 = "Γ. int";
                    QuestionDisp.newD4 = "Δ. κανένα απο τα παραπάνω";
                    actualAnswer4 = "Β";
                }

                if (questionNumber4 == 4)
                {
                    QuestionDisp.newQuestion4 = "Ποια ακολουθία διαφυγής χρησιμοποιούμε για να αλλάξουμε γραμμή;";
                    QuestionDisp.newA4 = "Α. \\n";
                    QuestionDisp.newB4 = "Β. \\b";
                    QuestionDisp.newC4 = "Γ. \\t";
                    QuestionDisp.newD4 = "Δ. \\\"";
                    actualAnswer4 = "Α";
                }

                if (questionNumber4 == 5)
                {
                    QuestionDisp.newQuestion4 = "Ποια απο τις παρακάτω εντολές διαβάζει έναν ακέραιο αριθμό και τον αποθηκεύει στην μεταβλητη i;";
                    QuestionDisp.newA4 = "Α. scanf(\"%d\",&i)";
                    QuestionDisp.newB4 = "Β. scan(\"%d\", &i);";
                    QuestionDisp.newC4 = "Γ. scanf(\"%f\", &i);";
                    QuestionDisp.newD4 = "Δ. scanf(\"%d\", &i);";
                    actualAnswer4 = "Δ";
                }

                if (questionNumber4 == 6)
                {
                    QuestionDisp.newQuestion4 = "Ποια απο τις παρακάτω εντολές δηλώνει έναν πραγματικό αριθμό;";
                    QuestionDisp.newA4 = "Α. float i";
                    QuestionDisp.newB4 = "Β. int i";
                    QuestionDisp.newC4 = "Γ. float i;";
                    QuestionDisp.newD4 = "Δ. int i;";
                    actualAnswer4 = "Γ";
                }

                if (questionNumber4 == 7)
                {
                    QuestionDisp.newQuestion4 = "Ποια απο τις παρακάτω εντολές δηλώνει μια μεταβλητή ως σταθερα;";
                    QuestionDisp.newA4 = "Α. int x;";
                    QuestionDisp.newB4 = "Β. const int x;";
                    QuestionDisp.newC4 = "Γ. const x = 5;";
                    QuestionDisp.newD4 = "Δ. const int x = 5;";
                    actualAnswer4 = "Δ";
                }

                if (questionNumber4 == 8)
                {
                    QuestionDisp.newQuestion4 = "Ποιές απο τις παρακάτω εντολές δηλώνει μια μακροεντολή;";
                    QuestionDisp.newA4 = "Α. #define SIZE 100;";
                    QuestionDisp.newB4 = "Β. #define SIZE;";
                    QuestionDisp.newC4 = "Γ. #define SIZE 100";
                    QuestionDisp.newD4 = "Δ. #define SIZE";
                    actualAnswer4 = "Γ";
                }

                if (questionNumber4 == 9)
                {
                    QuestionDisp.newQuestion4 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος; \r\n #include <stdio.h>\r\nint main () {\r\n\tprintf(\"Hello\\n\");\r\n\tprintf(\"World\");\r\n\treturn 0;\r\n};";
                    QuestionDisp.newA4 = "Α. Hello\r\n   World";
                    QuestionDisp.newB4 = "Β. Hello World";
                    QuestionDisp.newC4 = "Γ. Hello\tworld";
                    QuestionDisp.newD4 = "Δ. \"Hello\" \"World\"";
                    actualAnswer4 = "Α";
                }

                if (questionNumber4 == 10)
                {
                    QuestionDisp.newQuestion4 = "Ποια είναι η έξοδος του παρακάτω προγράμματος;\r\n#inlude <stdio.h>\r\nint main() {\r\n\tint x = 20, y = 10;\r\n\tprintf(\"%d + %d = %d\\n\", x, y, x + y);\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. %d + %d = %d";
                    QuestionDisp.newB4 = "Β. x + y = x + y";
                    QuestionDisp.newC4 = "Γ. 20 + 10 = 30";
                    QuestionDisp.newD4 = "Δ. x + y = 30";
                    actualAnswer4 = "Γ";
                }

                if (questionNumber4 == 11)
                {
                    QuestionDisp.newQuestion4 = "Ποια η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat x = 1.2365;\r\n\tprintf(\"Value = %f\\n\", x);\r\n\tprintf(\"Value = %.2f\\n\", x);\r\n\tprintf(\"Value = %.*f\\n\", 3, x);\r\n\tprintf(\"Value = %.f\\n\", x);\r\n\treturn 0;\r\n};";
                    QuestionDisp.newA4 = "Α. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 1;";
                    QuestionDisp.newB4 = "Β. Value = 1.2365\r  Value = 1.24\r\n  Value = 1.23\r\t   Value = 0.1";
                    QuestionDisp.newC4 = "Γ. Value = 1.236500\r   Value = 1.24\r\n  Value = 1.23\r\t   Value = 1";
                    QuestionDisp.newD4 = "Δ. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 0.1";
                    actualAnswer4 = "Α";
                }

                if (questionNumber4 == 12)
                {
                    QuestionDisp.newQuestion4 = "Ποιός απο τους παρακάτω τελεστές χρησιμοποιείται για την εκχώρηση τιμής σε μία μεταβλητή;";
                    QuestionDisp.newA4 = "Α. ->";
                    QuestionDisp.newB4 = "Β. <-";
                    QuestionDisp.newC4 = "Γ. =";
                    QuestionDisp.newD4 = "Δ. ==";
                    actualAnswer4 = "Γ";
                }

                if (questionNumber4 == 13)
                {
                    QuestionDisp.newQuestion4 = "Ποιό θα είναι το αποτέλεσμα της πράξης 3/2 αν και οι δύο αριθμοί είναι ακέραιοι;";
                    QuestionDisp.newA4 = "Α. 1.5";
                    QuestionDisp.newB4 = "Β. 1.0";
                    QuestionDisp.newC4 = "Γ. 1";
                    QuestionDisp.newD4 = "Δ. τίποτα απο τα παραπάνω";
                    actualAnswer4 = "Γ";
                }

                if (questionNumber4 == 14)
                {
                    QuestionDisp.newQuestion4 = "Ποιά θα είναι η έξοδος του παρακάτω προγράμματος ;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\tx++;\r\n\tprintf(\"%d\\n\", x);\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. 5";
                    QuestionDisp.newB4 = "Β. 6";
                    QuestionDisp.newC4 = "Γ. 7";
                    QuestionDisp.newD4 = "Δ. x++";
                    actualAnswer4 = "Β";
                }

                if (questionNumber4 == 15)
                {

                    QuestionDisp.newQuestion4 = "H έκφραση if(z) είναι ισοδύναμη με την if(z != 0)";
                    QuestionDisp.newA4 = "Α. Σωστό";
                    QuestionDisp.newB4 = "Β. Λαθος";
                    QuestionDisp.newC4 = "Γ. Μη έγκυρη έκφραση";
                    QuestionDisp.newD4 = "Δ. Τίποτα απο τα δύο";
                    actualAnswer4 = "Α";
                }

                if (questionNumber4 == 16)
                {
                    QuestionDisp.newQuestion4 = "H έκφραση if(!z) δεν είναι ισοδύναμη με την if(z == 0)";
                    QuestionDisp.newA4 = "Α. Σωστό";
                    QuestionDisp.newB4 = "Β. Λάθος";
                    QuestionDisp.newC4 = "Γ. Μη έγκυρη έκφραση";
                    QuestionDisp.newD4 = "Δ. Τίποτα απο τα παραπάνω";
                    actualAnswer4 = "Β";
                }

                if (questionNumber4 == 17)
                {
                    QuestionDisp.newQuestion4 = "Ποιά είναι η έξοδος του προγράμματος;\r\n#inlcude <stdio.h>\r\nint main() {\r\n\tint i = 0;\r\n\tif (i = 0) {\r\n\t\tprintf(\"i equals to zero!\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. i = 0";
                    QuestionDisp.newB4 = "Β. 0 equals to zero";
                    QuestionDisp.newC4 = "Γ. i equals to zero";
                    QuestionDisp.newD4 = "Δ. το πρόγραμμα δεν θα εμφανίσει τίποτα";
                    actualAnswer4 = "Δ";
                }

                if (questionNumber4 == 18)
                {
                    QuestionDisp.newQuestion4 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος;\r\n\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 0;\r\n\tif (x = 0) {\r\n\t\tprintf(\"x equals to zero\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"x  EQUALS TO ZERO\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. x equals to zero";
                    QuestionDisp.newB4 = "Β. 0 equals to zero";
                    QuestionDisp.newC4 = "Γ. x EQUALS TO ZERO";
                    QuestionDisp.newD4 = "Δ. το πρόγραμμα δεν θα εμφανίσει τίποτα";
                    actualAnswer4 = "Γ";
                }

                if (questionNumber4 == 19)
                {
                    QuestionDisp.newQuestion4 = "Ποιά θα είναι η συνθήκη στην  if εαν θέλουμε να εμφανίσουμε την απόλυτη τιμή ενός ακέραιου αριθμού;\r\n#include <stdio.h>\r\nint main() {\r\n\tint number;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d\", &number);\r\n\t\r\n\tif(....... ) {\r\n\t\tprintf(\"The absolute value is %d\\n\", number);\r\n\t}\r\n\telse {\r\n\t\tprintf(\"The absolute value is %d\\n\", -number);\r\n\t}\r\n\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. number >= 0";
                    QuestionDisp.newB4 = "Β. number <= 0";
                    QuestionDisp.newC4 = "Γ. number == 0";
                    QuestionDisp.newD4 = "Δ. number != 0";
                    actualAnswer4 = "Α";
                }

                if (questionNumber4 == 20)
                {
                    QuestionDisp.newQuestion4 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 1, y = 2;\r\n\tif (x && x/y) {\r\n\t\tprintf(\"Yes\\n\"); \r\n\t}\r\n\telse {\r\n\t\tprintf(\"No\\n\"); \r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. Yes";
                    QuestionDisp.newB4 = "Β. Yes\nNo";
                    QuestionDisp.newC4 = "Γ. Τίποτα γιατί είναι λάθος η συνθήκη.";
                    QuestionDisp.newD4 = "Δ. No";
                    actualAnswer4 = "Δ";
                }

                if (questionNumber4 == 21)
                {
                    QuestionDisp.newQuestion4 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat i = 1.2;\r\n\r\n\tif(i == 1.2) {\r\n\t\tprintf(\"Yes\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"No\\n\");\t\r\n\r\n\treturn 0;\r\n}\r\n";
                    QuestionDisp.newA4 = "Α. Yes";
                    QuestionDisp.newB4 = "Β. No";
                    QuestionDisp.newC4 = "Γ. Τίποτα γιατί η συνθήκη είναι λάθος.";
                    QuestionDisp.newD4 = "Δ. Τίποτα απο τα παραπάνω.";
                    actualAnswer4 = "Β";
                }

                if (questionNumber4 == 22)
                {
                    QuestionDisp.newQuestion4 = "Ποια είναι η έξοδος του προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x, y;\r\n\tx = y = 19;\r\n\tif(++x == y++) {\r\n\t\tprintf(\"One\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"Two\\n\");\r\n\t}\r\n\tprintf(\"%d %d\\n\", x, y);\t\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. One \r\n 20 20";
                    QuestionDisp.newB4 = "Β. Two\r\n 19 20";
                    QuestionDisp.newC4 = "Γ. Two\r\n 20 19";
                    QuestionDisp.newD4 = "Δ. Two\r\n 20 20";
                    actualAnswer4 = "Δ";
                }

                if (questionNumber4 == 23)
                {
                    QuestionDisp.newQuestion4 = "Ποιά είναι η έξοδος του προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 2, y = 5, z = 3;\r\n\tif (x < y < z) {\r\n\t\tprintf(\"One\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"Two\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. Two";
                    QuestionDisp.newB4 = "Β. One";
                    QuestionDisp.newC4 = "Γ. Τίποτα η συνθήκη είναι λάθος.";
                    QuestionDisp.newD4 = "Δ. Τίποτα απο τα παραπάνω.";
                    actualAnswer4 = "Β";
                }

                if (questionNumber4 == 24)
                {
                    QuestionDisp.newQuestion4 = "Ποιά είναι η έξοδος του παραπάνω προγράμματος αν το number είναι 12;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d, &number\");\r\n\t(x > 10) ? printf(\"One\\n\"); : printf(\"Two\\n\");\t\r\n\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. x > 10";
                    QuestionDisp.newB4 = "Β. Two";
                    QuestionDisp.newC4 = "Γ. One";
                    QuestionDisp.newD4 = "Δ. τίποτα απο τα παραπάνω";
                    actualAnswer4 = "Γ";
                }

                if (questionNumber4 == 25)
                {
                    QuestionDisp.newQuestion4 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint i = 1;\r\n\tswitch(i) {\r\n\t\tcase 1:\r\n\t\t\tprintf(\"One\\n\");\r\n\t\treturn 0;\r\n\t\tcase 2:\r\n\t\t\tprintf(\"Two\\n\");\r\n\t\tbreak;\t\t}\r\n\t}\r\n\tprintf(\"End\\n\");\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. One\r\nEnd";
                    QuestionDisp.newB4 = "Β. One End";
                    QuestionDisp.newC4 = "Γ. Two\r\nEnd";
                    QuestionDisp.newD4 = "Δ. One";
                    actualAnswer4 = "Δ";
                }

                if (questionNumber4 == 26)
                {

                    QuestionDisp.newQuestion4 = "Τι θα πρέπει να γράψουμε μέσα στην for ωστε να εμφανίζει τους ακέραιους με αντίστροφη σειρά απο το 5 μέχρι το 1; # include <stdio.h>\r\nint main() {\r\n\tint i;\r\n\tfor(..........) {\r\n\t\tprintf(\"%d \");\t\r\n\t}\r\n\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. (i = 1; i <= 5; i++)";
                    QuestionDisp.newB4 = "Β. (i = 5; i >= 1; i--)";
                    QuestionDisp.newC4 = "Γ. (i = 5; i >= 1; --i)";
                    QuestionDisp.newD4 = "Δ. (i = 1; i <= 5; ++i);";
                    actualAnswer4 = "Β";
                }

                if (questionNumber4 == 27)
                {
                    QuestionDisp.newQuestion4 = "Όταν ξέρουμε τον αριθμό των επαναλήψεων, ποιόν βρόχο επανάληψης προτιμάμε;";
                    QuestionDisp.newA4 = "Α. do-while";
                    QuestionDisp.newB4 = "Β. while";
                    QuestionDisp.newC4 = "Γ. if";
                    QuestionDisp.newD4 = "Δ. for";
                    actualAnswer4 = "Δ";
                }

                if (questionNumber4 == 28)
                {
                    QuestionDisp.newQuestion4 = "Όταν δεν ξέρουμε τον αριθμό των επαναλήψεων, ποιόν βρόχο επανάληψης προτιμάμε;";
                    QuestionDisp.newA4 = "Α. do-while";
                    QuestionDisp.newB4 = "Β. while";
                    QuestionDisp.newC4 = "Γ. if";
                    QuestionDisp.newD4 = "Δ. for";
                    actualAnswer4 = "Β";
                }

                if (questionNumber4 == 29)
                {
                    QuestionDisp.newQuestion4 = "Ποιός απο τους παρακάτω βρόχους επανάληψης εκτελείται τουλάχιστον μια φορά;";
                    QuestionDisp.newA4 = "Α. do-while";
                    QuestionDisp.newB4 = "Β. while";
                    QuestionDisp.newC4 = "Γ. if";
                    QuestionDisp.newD4 = "Δ. for";
                    actualAnswer4 = "Α";
                }

                if (questionNumber4 == 30)
                {
                    QuestionDisp.newQuestion4 = "Ποιά είναι η έξοδος του παρακάτω προγράμματος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\twhile(x != 0) {\r\n\t\tprintf(\"%d \", x);\r\n\t\tx++;\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. 0 1 2 3 4 5";
                    QuestionDisp.newB4 = "Β. 5 4 3 2 1 0";
                    QuestionDisp.newC4 = "Γ. 5 4 3 2 1";
                    QuestionDisp.newD4 = "Δ. 1 2 3 4 5";
                    actualAnswer4 = "Γ";
                }

                if (questionNumber4 == 31)
                {
                    QuestionDisp.newQuestion4 = "Πόσες φορές εκελείται ο while βρόχος;\r\n#include <stdio.h>\r\nint main() {\r\n\tint a = 256, b = 4;\r\n\twhile(a != b) {\r\n\t\tb = b*b\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. 3 φορές";
                    QuestionDisp.newB4 = "Β. 0 φορές";
                    QuestionDisp.newC4 = "Γ. 20 φορές";
                    QuestionDisp.newD4 = "Δ. 2 φορές";
                    actualAnswer4 = "Δ";
                }

                if (questionNumber4 == 32)
                {
                    QuestionDisp.newQuestion4 = "Ποιά συνθήκη πρέπει να προστεθεί στη εντολή while ώστε το πρόγραμμα να εμφανίσει τους αριθμούς απο το 1 μέχρι το 5;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 1;\r\n\tdo{\r\n\t\tprintf(\"%d\\n\", x);\r\n\t\tx++;\r\n\t} while(.......);\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. i < 5";
                    QuestionDisp.newB4 = "Β. i <= 5";
                    QuestionDisp.newC4 = "Γ. i <= 5;";
                    QuestionDisp.newD4 = "Δ. i < 5;";
                    actualAnswer4 = "Β";
                }

                if (questionNumber4 == 33)
                {
                    QuestionDisp.newQuestion4 = "Συμπληρώστε τις εντολές ώστε τι πρόγραμμα να εμφανίζει την λέξη \"Correct\" τόσες φορές όσες και ο ακέραιος που θα δωθεί ως είσοδο.\r\n#include <stdio.h>\r\nint main() {\r\n\tint i, number;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d\", &number);\r\n\ti = 1;\r\n\tdo { ......\r\n\t} while(i <= number);\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "Α. printf(\"Correct\\n\");\r\n   i++";
                    QuestionDisp.newB4 = "Β. i++;";
                    QuestionDisp.newC4 = "Γ. printf(\"Correct\\n\");";
                    QuestionDisp.newD4 = "Δ. printf(\"Correct\\n\"); \r\n   i++;";
                    actualAnswer4 = "Δ";
                }



                if (questionNumber4 > totalQuestions4)
                {
                    quizCompleted4 = true;
                }
                /*  if (questionNumber4 > 4)
                  {
                      questionNumber4 = 1;
                  } */

                // all question go above this line
                QuestionDisp.pleaseUpdate = false;
                questionNumber4++;

                if (questionNumber4 == totalQuestions4)
                {
                    AnswerButtons4.EndQuiz();
                }
            }

        }

    }
}