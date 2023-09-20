using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGen : MonoBehaviour
{
    public static string actualAnswer2;
    public static bool displayingQuestion2 = false;

    public int questionNumber2; // ������������� ��� ������ ��� ������ ��������.
    public int totalQuestions2 = 13; // ������ ������� ���������.
    private bool quizCompleted2 = false; // ��������� ��� ����������� �� ������������ �� �����.

    public AnswerBtn answerButtons2;


    void Start() // �������������� �� ������ Start ��� ��� ������������.
    {
        displayingQuestion2 = false; // ����� ��� ����� ���� ������ � �����.
        questionNumber2 = 1; // ������������� ��� ������ ��� ������ ��������.
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

                    QuestionDis.newQuestion2 = "H ������� if(z) ����� ��������� �� ��� if(z != 0)";
                    QuestionDis.newA2 = "�. �����";
                    QuestionDis.newB2 = "�. �����";
                    QuestionDis.newC2 = "�. �� ������ �������";
                    QuestionDis.newD2 = "�. ������ ��� �� ���";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 2)
                {
                    QuestionDis.newQuestion2 = "H ������� if(!z) ��� ����� ��������� �� ��� if(z == 0)";
                    QuestionDis.newA2 = "�. �����";
                    QuestionDis.newB2 = "�. �����";
                    QuestionDis.newC2 = "�. �� ������ �������";
                    QuestionDis.newD2 = "�. ������ ��� �� ��������";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 3)
                {
                    QuestionDis.newQuestion2 = "���� ����� � ������ ��� ������������;\r\n#inlcude <stdio.h>\r\nint main() {\r\n\tint i = 0;\r\n\tif (i = 0) {\r\n\t\tprintf(\"i equals to zero!\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "�. i = 0";
                    QuestionDis.newB2 = "�. 0 equals to zero";
                    QuestionDis.newC2 = "�. i equals to zero";
                    QuestionDis.newD2 = "�. �� ��������� ��� �� ��������� ������";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 4)
                {
                    QuestionDis.newQuestion2 = "���� ����� � ������ ��� �������� ������������;\r\n\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 0;\r\n\tif (x = 0) {\r\n\t\tprintf(\"x equals to zero\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"x  EQUALS TO ZERO\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "�. x equals to zero";
                    QuestionDis.newB2 = "�. 0 equals to zero";
                    QuestionDis.newC2 = "�. x EQUALS TO ZERO";
                    QuestionDis.newD2 = "�. �� ��������� ��� �� ��������� ������";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 5)
                {
                    QuestionDis.newQuestion2 = "���� �� ����� � ������� ����  if ��� ������� �� ����������� ��� ������� ���� ���� �������� �������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint number;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d\", &number);\r\n\t\r\n\tif(....... ) {\r\n\t\tprintf(\"The absolute value is %d\\n\", number);\r\n\t}\r\n\telse {\r\n\t\tprintf(\"The absolute value is %d\\n\", -number);\r\n\t}\r\n\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "�. number >= 0";
                    QuestionDis.newB2 = "�. number <= 0";
                    QuestionDis.newC2 = "�. number == 0";
                    QuestionDis.newD2 = "�. number != 0";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 6)
                {
                    QuestionDis.newQuestion2 = "���� ����� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 1, y = 2;\r\n\tif (x && x/y) {\r\n\t\tprintf(\"Yes\\n\"); \r\n\t}\r\n\telse {\r\n\t\tprintf(\"No\\n\"); \r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "�. Yes";
                    QuestionDis.newB2 = "�. Yes\nNo";
                    QuestionDis.newC2 = "�. ������ ����� ����� ����� � �������.";
                    QuestionDis.newD2 = "�. No";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 7)
                {
                    QuestionDis.newQuestion2 = "���� ����� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat i = 1.2;\r\n\r\n\tif(i == 1.2) {\r\n\t\tprintf(\"Yes\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"No\\n\");\t\r\n\r\n\treturn 0;\r\n}\r\n";
                    QuestionDis.newA2 = "�. Yes";
                    QuestionDis.newB2 = "�. No";
                    QuestionDis.newC2 = "�. ������ ����� � ������� ����� �����.";
                    QuestionDis.newD2 = "�. ������ ��� �� ��������.";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 8)
                {
                    QuestionDis.newQuestion2 = "���� ����� � ������ ��� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x, y;\r\n\tx = y = 19;\r\n\tif(++x == y++) {\r\n\t\tprintf(\"One\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"Two\\n\");\r\n\t}\r\n\tprintf(\"%d %d\\n\", x, y);\t\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "�. One \r\n 20 20";
                    QuestionDis.newB2 = "�. Two\r\n 19 20";
                    QuestionDis.newC2 = "�. Two\r\n 20 19";
                    QuestionDis.newD2 = "�. Two\r\n 20 20";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 9)
                {
                    QuestionDis.newQuestion2 = "���� ����� � ������ ��� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 2, y = 5, z = 3;\r\n\tif (x < y < z) {\r\n\t\tprintf(\"One\\n\");\r\n\t}\r\n\telse {\r\n\t\tprintf(\"Two\\n\");\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "�. Two";
                    QuestionDis.newB2 = "�. One";
                    QuestionDis.newC2 = "�. ������ � ������� ����� �����.";
                    QuestionDis.newD2 = "�. ������ ��� �� ��������.";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 10)
                {
                    QuestionDis.newQuestion2 = "���� ����� � ������ ��� �������� ������������ �� �� number ����� 12;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d, &number\");\r\n\t(x > 10) ? printf(\"One\\n\"); : printf(\"Two\\n\");\t\r\n\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "�. x > 10";
                    QuestionDis.newB2 = "�. Two";
                    QuestionDis.newC2 = "�. One";
                    QuestionDis.newD2 = "�. ������ ��� �� ��������";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 11)
                {
                    QuestionDis.newQuestion2 = "���� ����� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint i = 1;\r\n\tswitch(i) {\r\n\t\tcase 1:\r\n\t\t\tprintf(\"One\\n\");\r\n\t\treturn 0;\r\n\t\tcase 2:\r\n\t\t\tprintf(\"Two\\n\");\r\n\t\tbreak;\t\t}\r\n\t}\r\n\tprintf(\"End\\n\");\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "�. One\r\nEnd";
                    QuestionDis.newB2 = "�. One End";
                    QuestionDis.newC2 = "�. Two\r\nEnd";
                    QuestionDis.newD2 = "�. One";
                    actualAnswer2 = "�";
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
