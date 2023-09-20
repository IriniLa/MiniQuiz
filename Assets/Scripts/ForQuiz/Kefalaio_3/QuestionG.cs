using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionG : MonoBehaviour
{
    public static string actualAnswer3;
    public static bool displayingQuestion3 = false;

    public int questionNumber3; // ������������� ��� ������ ��� ������ ��������.
    public int totalQuestions3 = 10; // ������ ������� ���������.
    private bool quizCompleted3 = false; // ��������� ��� ����������� �� ������������ �� �����.

    public AnswerBt AnswerButtons3;


    void Start() // �������������� �� ������ Start ��� ��� ������������.
    {
        displayingQuestion3 = false; // ����� ��� ����� ���� ������ � �����.
        questionNumber3 = 1; // ������������� ��� ������ ��� ������ ��������.
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

                    QuestionD.newQuestion3 = "�� �� ������ �� �������� ���� ���� for ���� �� ��������� ���� ��������� �� ���������� ����� ��� �� 5 ����� �� 1; # include <stdio.h>\r\nint main() {\r\n\tint i;\r\n\tfor(..........) {\r\n\t\tprintf(\"%d \");\t\r\n\t}\r\n\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "�. (i = 1; i <= 5; i++)";
                    QuestionD.newB3 = "�. (i = 5; i >= 1; i--)";
                    QuestionD.newC3 = "�. (i = 5; i >= 1; --i)";
                    QuestionD.newD3 = "�. (i = 1; i <= 5; ++i);";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 2)
                {
                    QuestionD.newQuestion3 = "���� ������� ��� ������ ��� �����������, ����� ����� ���������� ���������;";
                    QuestionD.newA3 = "�. do-while";
                    QuestionD.newB3 = "�. while";
                    QuestionD.newC3 = "�. if";
                    QuestionD.newD3 = "�. for";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 3)
                {
                    QuestionD.newQuestion3 = "���� ��� ������� ��� ������ ��� �����������, ����� ����� ���������� ���������;";
                    QuestionD.newA3 = "�. do-while";
                    QuestionD.newB3 = "�. while";
                    QuestionD.newC3 = "�. if";
                    QuestionD.newD3 = "�. for";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 4)
                {
                    QuestionD.newQuestion3 = "����� ��� ���� �������� ������� ���������� ���������� ����������� ��� ����;";
                    QuestionD.newA3 = "�. do-while";
                    QuestionD.newB3 = "�. while";
                    QuestionD.newC3 = "�. if";
                    QuestionD.newD3 = "�. for";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 5)
                {
                    QuestionD.newQuestion3 = "���� ����� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\twhile(x != 0) {\r\n\t\tprintf(\"%d \", x);\r\n\t\tx++;\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "�. 0 1 2 3 4 5";
                    QuestionD.newB3 = "�. 5 4 3 2 1 0";
                    QuestionD.newC3 = "�. 5 4 3 2 1";
                    QuestionD.newD3 = "�. 1 2 3 4 5";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 6)
                {
                    QuestionD.newQuestion3 = "����� ����� ��������� � while ������;\r\n#include <stdio.h>\r\nint main() {\r\n\tint a = 256, b = 4;\r\n\twhile(a != b) {\r\n\t\tb = b*b\r\n\t}\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "�. 3 �����";
                    QuestionD.newB3 = "�. 0 �����";
                    QuestionD.newC3 = "�. 20 �����";
                    QuestionD.newD3 = "�. 2 �����";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 7)
                {
                    QuestionD.newQuestion3 = "���� ������� ������ �� ��������� ��� ������ while ���� �� ��������� �� ��������� ���� �������� ��� �� 1 ����� �� 5;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 1;\r\n\tdo{\r\n\t\tprintf(\"%d\\n\", x);\r\n\t\tx++;\r\n\t} while(.......);\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "�. i < 5";
                    QuestionD.newB3 = "�. i <= 5";
                    QuestionD.newC3 = "�. i <= 5;";
                    QuestionD.newD3 = "�. i < 5;";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 8)
                {
                    QuestionD.newQuestion3 = "����������� ��� ������� ���� �� ��������� �� ��������� ��� ���� \"Correct\" ����� ����� ���� ��� � �������� ��� �� ����� �� ������.\r\n#include <stdio.h>\r\nint main() {\r\n\tint i, number;\r\n\tprintf(\"Enter number: \");\r\n\tscanf(\"%d\", &number);\r\n\ti = 1;\r\n\tdo { ......\r\n\t} while(i <= number);\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "�. printf(\"Correct\\n\");\r\n   i++";
                    QuestionD.newB3 = "�. i++;";
                    QuestionD.newC3 = "�. printf(\"Correct\\n\");";
                    QuestionD.newD3 = "�. printf(\"Correct\\n\"); \r\n   i++;";
                    actualAnswer3 = "�";
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