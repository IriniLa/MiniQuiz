using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGene : MonoBehaviour
{
    public static string actualAnswer4;
    public static bool displayingQuestion4 = false;

    public int questionNumber4; // ������������� ��� ������ ��� ������ ��������.
    public int totalQuestions4 = 35; // ������ ������� ���������.
    private bool quizCompleted4 = false; // ��������� ��� ����������� �� ������������ �� �����.

    public AnswerBut AnswerButtons4;


    void Start() // �������������� �� ������ Start ��� ��� ������������.
    {
        displayingQuestion4 = false; // ����� ��� ����� ���� ������ � �����.
        questionNumber4 = 1; // ������������� ��� ������ ��� ������ ��������.
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

                    QuestionDisp.newQuestion4 = "���� ��� ��� �������� ������� ������� �� \"Hello World!\" ���� �����;";
                    QuestionDisp.newA4 = "�. print(\"Hello World\");";
                    QuestionDisp.newB4 = "�. printf(\"Hello World!\");";
                    QuestionDisp.newC4 = "�. printf(\"Hello World!\")";
                    QuestionDisp.newD4 = "�. printf(Hello World!);";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 2)
                {
                    QuestionDisp.newQuestion4 = "����� ���� ��������� �������������� ��� ��� ������ �������� ����������;";
                    QuestionDisp.newA4 = "�. char";
                    QuestionDisp.newB4 = "�. float";
                    QuestionDisp.newC4 = "�. int";
                    QuestionDisp.newD4 = "�. double";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 3)
                {
                    QuestionDisp.newQuestion4 = "����� ���� ��������� �������������� ��� ��� ������ ����������� ����������;";
                    QuestionDisp.newA4 = "�. char";
                    QuestionDisp.newB4 = "�. float";
                    QuestionDisp.newC4 = "�. int";
                    QuestionDisp.newD4 = "�. ������ ��� �� ��������";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 4)
                {
                    QuestionDisp.newQuestion4 = "���� ��������� �������� �������������� ��� �� ��������� ������;";
                    QuestionDisp.newA4 = "�. \\n";
                    QuestionDisp.newB4 = "�. \\b";
                    QuestionDisp.newC4 = "�. \\t";
                    QuestionDisp.newD4 = "�. \\\"";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 5)
                {
                    QuestionDisp.newQuestion4 = "���� ��� ��� �������� ������� �������� ���� ������� ������ ��� ��� ���������� ���� ��������� i;";
                    QuestionDisp.newA4 = "�. scanf(\"%d\",&i)";
                    QuestionDisp.newB4 = "�. scan(\"%d\", &i);";
                    QuestionDisp.newC4 = "�. scanf(\"%f\", &i);";
                    QuestionDisp.newD4 = "�. scanf(\"%d\", &i);";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 6)
                {
                    QuestionDisp.newQuestion4 = "���� ��� ��� �������� ������� ������� ���� ���������� ������;";
                    QuestionDisp.newA4 = "�. float i";
                    QuestionDisp.newB4 = "�. int i";
                    QuestionDisp.newC4 = "�. float i;";
                    QuestionDisp.newD4 = "�. int i;";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 7)
                {
                    QuestionDisp.newQuestion4 = "���� ��� ��� �������� ������� ������� ��� ��������� �� �������;";
                    QuestionDisp.newA4 = "�. int x;";
                    QuestionDisp.newB4 = "�. const int x;";
                    QuestionDisp.newC4 = "�. const x = 5;";
                    QuestionDisp.newD4 = "�. const int x = 5;";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 8)
                {
                    QuestionDisp.newQuestion4 = "����� ��� ��� �������� ������� ������� ��� �����������;";
                    QuestionDisp.newA4 = "�. #define SIZE 100;";
                    QuestionDisp.newB4 = "�. #define SIZE;";
                    QuestionDisp.newC4 = "�. #define SIZE 100";
                    QuestionDisp.newD4 = "�. #define SIZE";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 9)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� �������� ������������; \r\n #include <stdio.h>\r\nint main () {\r\n\tprintf(\"Hello\\n\");\r\n\tprintf(\"World\");\r\n\treturn 0;\r\n};";
                    QuestionDisp.newA4 = "�. Hello\r\n   World";
                    QuestionDisp.newB4 = "�. Hello World";
                    QuestionDisp.newC4 = "�. Hello\tworld";
                    QuestionDisp.newD4 = "�. \"Hello\" \"World\"";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 10)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� �������� ������������;\r\n#inlude <stdio.h>\r\nint main() {\r\n\tint x = 20, y = 10;\r\n\tprintf(\"%d + %d = %d\\n\", x, y, x + y);\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. %d + %d = %d";
                    QuestionDisp.newB4 = "�. x + y = x + y";
                    QuestionDisp.newC4 = "�. 20 + 10 = 30";
                    QuestionDisp.newD4 = "�. x + y = 30";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 11)
                {
                    QuestionDisp.newQuestion4 = "���� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat x = 1.2365;\r\n\tprintf(\"Value = %f\\n\", x);\r\n\tprintf(\"Value = %.2f\\n\", x);\r\n\tprintf(\"Value = %.*f\\n\", 3, x);\r\n\tprintf(\"Value = %.f\\n\", x);\r\n\treturn 0;\r\n};";
                    QuestionDisp.newA4 = "�. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 1;";
                    QuestionDisp.newB4 = "�. Value = 1.2365\r  Value = 1.24\r\n  Value = 1.23\r\t   Value = 0.1";
                    QuestionDisp.newC4 = "�. Value = 1.236500\r   Value = 1.24\r\n  Value = 1.23\r\t   Value = 1";
                    QuestionDisp.newD4 = "�. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 0.1";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 12)
                {
                    QuestionDisp.newQuestion4 = "����� ��� ���� �������� �������� ��������������� ��� ��� �������� ����� �� ��� ���������;";
                    QuestionDisp.newA4 = "�. ->";
                    QuestionDisp.newB4 = "�. <-";
                    QuestionDisp.newC4 = "�. =";
                    QuestionDisp.newD4 = "�. ==";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 13)
                {
                    QuestionDisp.newQuestion4 = "���� �� ����� �� ���������� ��� ������ 3/2 �� ��� �� ��� ������� ����� ��������;";
                    QuestionDisp.newA4 = "�. 1.5";
                    QuestionDisp.newB4 = "�. 1.0";
                    QuestionDisp.newC4 = "�. 1";
                    QuestionDisp.newD4 = "�. ������ ��� �� ��������";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 14)
                {
                    QuestionDisp.newQuestion4 = "���� �� ����� � ������ ��� �������� ������������ ;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\tx++;\r\n\tprintf(\"%d\\n\", x);\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. 5";
                    QuestionDisp.newB4 = "�. 6";
                    QuestionDisp.newC4 = "�. 7";
                    QuestionDisp.newD4 = "�. x++";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 15)
                {

                    QuestionDisp.newQuestion4 = "H ������� if(z) ����� ��������� �� ��� if(z != 0)";
                    QuestionDisp.newA4 = "�. �����";
                    QuestionDisp.newB4 = "�. �����";
                    QuestionDisp.newC4 = "�. �� ������ �������";
                    QuestionDisp.newD4 = "�. ������ ��� �� ���";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 16)
                {
                    QuestionDisp.newQuestion4 = "H ������� if(!z) ��� ����� ��������� �� ��� if(z == 0)";
                    QuestionDisp.newA4 = "�. �����";
                    QuestionDisp.newB4 = "�. �����";
                    QuestionDisp.newC4 = "�. �� ������ �������";
                    QuestionDisp.newD4 = "�. ������ ��� �� ��������";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 17)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� ������������;\r\n#inlcude <stdio.h>\r\nint main() {\r\n\tint i = 0;\r\n\tif (i = 0) {\r\n\t\tprintf(\"i equals to zero!\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. i = 0";
                    QuestionDisp.newB4 = "�. 0 equals to zero";
                    QuestionDisp.newC4 = "�. i equals to zero";
                    QuestionDisp.newD4 = "�. �� ��������� ��� �� ��������� ������";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 18)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� �������� ������������;\r\n\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 0;\r\n\tif (x = 0) {\r\n\t\tprintf(\"x equals to zero\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"x  EQUALS TO ZERO\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. x equals to zero";
                    QuestionDisp.newB4 = "�. 0 equals to zero";
                    QuestionDisp.newC4 = "�. x EQUALS TO ZERO";
                    QuestionDisp.newD4 = "�. �� ��������� ��� �� ��������� ������";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 19)
                {
                    QuestionDisp.newQuestion4 = "���� �� ����� � ������� ����  if ��� ������� �� ����������� ��� ������� ���� ���� �������� �������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint number;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d\", &number);\r\n\t\r\n\tif(....... ) {\r\n\t\tprintf(\"The absolute value is %d\\n\", number);\r\n\t}\r\n\telse {\r\n\t\tprintf(\"The absolute value is %d\\n\", -number);\r\n\t}\r\n\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. number >= 0";
                    QuestionDisp.newB4 = "�. number <= 0";
                    QuestionDisp.newC4 = "�. number == 0";
                    QuestionDisp.newD4 = "�. number != 0";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 20)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 1, y = 2;\r\n\tif (x && x/y) {\r\n\t\tprintf(\"Yes\\n\"); \r\n\t}\r\n\telse {\r\n\t\tprintf(\"No\\n\"); \r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. Yes";
                    QuestionDisp.newB4 = "�. Yes\nNo";
                    QuestionDisp.newC4 = "�. ������ ����� ����� ����� � �������.";
                    QuestionDisp.newD4 = "�. No";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 21)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat i = 1.2;\r\n\r\n\tif(i == 1.2) {\r\n\t\tprintf(\"Yes\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"No\\n\");\t\r\n\r\n\treturn 0;\r\n}\r\n";
                    QuestionDisp.newA4 = "�. Yes";
                    QuestionDisp.newB4 = "�. No";
                    QuestionDisp.newC4 = "�. ������ ����� � ������� ����� �����.";
                    QuestionDisp.newD4 = "�. ������ ��� �� ��������.";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 22)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x, y;\r\n\tx = y = 19;\r\n\tif(++x == y++) {\r\n\t\tprintf(\"One\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"Two\\n\");\r\n\t}\r\n\tprintf(\"%d %d\\n\", x, y);\t\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. One \r\n 20 20";
                    QuestionDisp.newB4 = "�. Two\r\n 19 20";
                    QuestionDisp.newC4 = "�. Two\r\n 20 19";
                    QuestionDisp.newD4 = "�. Two\r\n 20 20";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 23)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 2, y = 5, z = 3;\r\n\tif (x < y < z) {\r\n\t\tprintf(\"One\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"Two\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. Two";
                    QuestionDisp.newB4 = "�. One";
                    QuestionDisp.newC4 = "�. ������ � ������� ����� �����.";
                    QuestionDisp.newD4 = "�. ������ ��� �� ��������.";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 24)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� �������� ������������ �� �� number ����� 12;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d, &number\");\r\n\t(x > 10) ? printf(\"One\\n\"); : printf(\"Two\\n\");\t\r\n\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. x > 10";
                    QuestionDisp.newB4 = "�. Two";
                    QuestionDisp.newC4 = "�. One";
                    QuestionDisp.newD4 = "�. ������ ��� �� ��������";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 25)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint i = 1;\r\n\tswitch(i) {\r\n\t\tcase 1:\r\n\t\t\tprintf(\"One\\n\");\r\n\t\treturn 0;\r\n\t\tcase 2:\r\n\t\t\tprintf(\"Two\\n\");\r\n\t\tbreak;\t\t}\r\n\t}\r\n\tprintf(\"End\\n\");\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. One\r\nEnd";
                    QuestionDisp.newB4 = "�. One End";
                    QuestionDisp.newC4 = "�. Two\r\nEnd";
                    QuestionDisp.newD4 = "�. One";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 26)
                {

                    QuestionDisp.newQuestion4 = "�� �� ������ �� �������� ���� ���� for ���� �� ��������� ���� ��������� �� ���������� ����� ��� �� 5 ����� �� 1; # include <stdio.h>\r\nint main() {\r\n\tint i;\r\n\tfor(..........) {\r\n\t\tprintf(\"%d \");\t\r\n\t}\r\n\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. (i = 1; i <= 5; i++)";
                    QuestionDisp.newB4 = "�. (i = 5; i >= 1; i--)";
                    QuestionDisp.newC4 = "�. (i = 5; i >= 1; --i)";
                    QuestionDisp.newD4 = "�. (i = 1; i <= 5; ++i);";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 27)
                {
                    QuestionDisp.newQuestion4 = "���� ������� ��� ������ ��� �����������, ����� ����� ���������� ���������;";
                    QuestionDisp.newA4 = "�. do-while";
                    QuestionDisp.newB4 = "�. while";
                    QuestionDisp.newC4 = "�. if";
                    QuestionDisp.newD4 = "�. for";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 28)
                {
                    QuestionDisp.newQuestion4 = "���� ��� ������� ��� ������ ��� �����������, ����� ����� ���������� ���������;";
                    QuestionDisp.newA4 = "�. do-while";
                    QuestionDisp.newB4 = "�. while";
                    QuestionDisp.newC4 = "�. if";
                    QuestionDisp.newD4 = "�. for";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 29)
                {
                    QuestionDisp.newQuestion4 = "����� ��� ���� �������� ������� ���������� ���������� ����������� ��� ����;";
                    QuestionDisp.newA4 = "�. do-while";
                    QuestionDisp.newB4 = "�. while";
                    QuestionDisp.newC4 = "�. if";
                    QuestionDisp.newD4 = "�. for";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 30)
                {
                    QuestionDisp.newQuestion4 = "���� ����� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\twhile(x != 0) {\r\n\t\tprintf(\"%d \", x);\r\n\t\tx++;\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. 0 1 2 3 4 5";
                    QuestionDisp.newB4 = "�. 5 4 3 2 1 0";
                    QuestionDisp.newC4 = "�. 5 4 3 2 1";
                    QuestionDisp.newD4 = "�. 1 2 3 4 5";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 31)
                {
                    QuestionDisp.newQuestion4 = "����� ����� ��������� � while ������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint a = 256, b = 4;\r\n\twhile(a != b) {\r\n\t\tb = b*b\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. 3 �����";
                    QuestionDisp.newB4 = "�. 0 �����";
                    QuestionDisp.newC4 = "�. 20 �����";
                    QuestionDisp.newD4 = "�. 2 �����";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 32)
                {
                    QuestionDisp.newQuestion4 = "���� ������� ������ �� ��������� ��� ������ while ���� �� ��������� �� ��������� ���� �������� ��� �� 1 ����� �� 5;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 1;\r\n\tdo{\r\n\t\tprintf(\"%d\\n\", x);\r\n\t\tx++;\r\n\t} while(.......);\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. i < 5";
                    QuestionDisp.newB4 = "�. i <= 5";
                    QuestionDisp.newC4 = "�. i <= 5;";
                    QuestionDisp.newD4 = "�. i < 5;";
                    actualAnswer4 = "�";
                }

                if (questionNumber4 == 33)
                {
                    QuestionDisp.newQuestion4 = "����������� ��� ������� ���� �� ��������� �� ��������� ��� ���� \"Correct\" ����� ����� ���� ��� � �������� ��� �� ����� �� ������.\r\n#include <stdio.h>\r\nint main() {\r\n\tint i, number;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d\", &number);\r\n\ti = 1;\r\n\tdo { ......\r\n\t} while(i <= number);\r\n\treturn 0;\r\n}";
                    QuestionDisp.newA4 = "�. printf(\"Correct\\n\");\r\n   i++";
                    QuestionDisp.newB4 = "�. i++;";
                    QuestionDisp.newC4 = "�. printf(\"Correct\\n\");";
                    QuestionDisp.newD4 = "�. printf(\"Correct\\n\"); \r\n   i++;";
                    actualAnswer4 = "�";
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