using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionG : MonoBehaviour
{
    public static string actualAnswer3;
    public static bool displayingQuestion3 = false;

    public int questionNumber3; // ������������� ��� ������ ��� ������ ��������.
    public int totalQuestions3 = 16; // ������ ������� ���������.
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

                    QuestionD.newQuestion3 = "���� ��� ��� �������� ������� ������� �� \"Hello World!\" ���� �����;";
                    QuestionD.newA3 = "�. print(\"Hello World\");";
                    QuestionD.newB3 = "�. printf(\"Hello World!\");";
                    QuestionD.newC3 = "�. printf(\"Hello World!\")";
                    QuestionD.newD3 = "�. printf(Hello World!);";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 2)
                {
                    QuestionD.newQuestion3 = "����� ���� ��������� �������������� ��� ��� ������ �������� ����������;";
                    QuestionD.newA3 = "�. char";
                    QuestionD.newB3 = "�. float";
                    QuestionD.newC3 = "�. int";
                    QuestionD.newD3 = "�. double";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 3)
                {
                    QuestionD.newQuestion3 = "����� ���� ��������� �������������� ��� ��� ������ ����������� ����������;";
                    QuestionD.newA3 = "�. char";
                    QuestionD.newB3 = "�. float";
                    QuestionD.newC3 = "�. int";
                    QuestionD.newD3 = "�. ������ ��� �� ��������";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 4)
                {
                    QuestionD.newQuestion3 = "���� ��������� �������� �������������� ��� �� ��������� ������;";
                    QuestionD.newA3 = "�. \\n";
                    QuestionD.newB3 = "�. \\b";
                    QuestionD.newC3 = "�. \\t";
                    QuestionD.newD3 = "�. \\\"";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 5)
                {
                    QuestionD.newQuestion3 = "���� ��� ��� �������� ������� �������� ���� ������� ������ ��� ��� ���������� ���� ��������� i;";
                    QuestionD.newA3 = "�. scanf(\"%d\",&i)";
                    QuestionD.newB3 = "�. scan(\"%d\", &i);";
                    QuestionD.newC3 = "�. scanf(\"%f\", &i);";
                    QuestionD.newD3 = "�. scanf(\"%d\", &i);";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 6)
                {
                    QuestionD.newQuestion3 = "���� ��� ��� �������� ������� ������� ���� ���������� ������;";
                    QuestionD.newA3 = "�. float i";
                    QuestionD.newB3 = "�. int i";
                    QuestionD.newC3 = "�. float i;";
                    QuestionD.newD3 = "�. int i;";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 7)
                {
                    QuestionD.newQuestion3 = "���� ��� ��� �������� ������� ������� ��� ��������� �� �������;";
                    QuestionD.newA3 = "�. int x;";
                    QuestionD.newB3 = "�. const int x;";
                    QuestionD.newC3 = "�. const x = 5;";
                    QuestionD.newD3 = "�. const int x = 5;";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 8)
                {
                    QuestionD.newQuestion3 = "����� ��� ��� �������� ������� ������� ��� �����������;";
                    QuestionD.newA3 = "�. #define SIZE 100;";
                    QuestionD.newB3 = "�. #define SIZE;";
                    QuestionD.newC3 = "�. #define SIZE 100";
                    QuestionD.newD3 = "�. #define SIZE";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 9)
                {
                    QuestionD.newQuestion3 = "���� ����� � ������ ��� �������� ������������; \r\n #include <stdio.h>\r\nint main () {\r\n\tprintf(\"Hello\\n\");\r\n\tprintf(\"World\");\r\n\treturn 0;\r\n};";
                    QuestionD.newA3 = "�. Hello\r\n   World";
                    QuestionD.newB3 = "�. Hello World";
                    QuestionD.newC3 = "�. Hello\tworld";
                    QuestionD.newD3 = "�. \"Hello\" \"World\"";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 10)
                {
                    QuestionD.newQuestion3 = "���� ����� � ������ ��� �������� ������������;\r\n#inlude <stdio.h>\r\nint main() {\r\n\tint x = 20, y = 10;\r\n\tprintf(\"%d + %d = %d\\n\", x, y, x + y);\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "�. %d + %d = %d";
                    QuestionD.newB3 = "�. x + y = x + y";
                    QuestionD.newC3 = "�. 20 + 10 = 30";
                    QuestionD.newD3 = "�. x + y = 30";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 11)
                {
                    QuestionD.newQuestion3 = "���� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat x = 1.2365;\r\n\tprintf(\"Value = %f\\n\", x);\r\n\tprintf(\"Value = %.2f\\n\", x);\r\n\tprintf(\"Value = %.*f\\n\", 3, x);\r\n\tprintf(\"Value = %.f\\n\", x);\r\n\treturn 0;\r\n};";
                    QuestionD.newA3 = "�. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 1;";
                    QuestionD.newB3 = "�. Value = 1.2365\r  Value = 1.24\r\n  Value = 1.23\r\t   Value = 0.1";
                    QuestionD.newC3 = "�. Value = 1.236500\r   Value = 1.24\r\n  Value = 1.23\r\t   Value = 1";
                    QuestionD.newD3 = "�. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 0.1";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 12)
                {
                    QuestionD.newQuestion3 = "����� ��� ���� �������� �������� ��������������� ��� ��� �������� ����� �� ��� ���������;";
                    QuestionD.newA3 = "�. ->";
                    QuestionD.newB3 = "�. <-";
                    QuestionD.newC3 = "�. =";
                    QuestionD.newD3 = "�. ==";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 13)
                {
                    QuestionD.newQuestion3 = "���� �� ����� �� ���������� ��� ������ 3/2 �� ��� �� ��� ������� ����� ��������;";
                    QuestionD.newA3 = "�. 1.5";
                    QuestionD.newB3 = "�. 1.0";
                    QuestionD.newC3 = "�. 1";
                    QuestionD.newD3 = "�. ������ ��� �� ��������";
                    actualAnswer3 = "�";
                }

                if (questionNumber3 == 14)
                {
                    QuestionD.newQuestion3 = "���� �� ����� � ������ ��� �������� ������������ ;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\tx++;\r\n\tprintf(\"%d\\n\", x);\r\n\treturn 0;\r\n}";
                    QuestionD.newA3 = "�. 5";
                    QuestionD.newB3 = "�. 6";
                    QuestionD.newC3 = "�. 7";
                    QuestionD.newD3 = "�. x++";
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