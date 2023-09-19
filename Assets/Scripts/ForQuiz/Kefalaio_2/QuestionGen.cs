using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGen : MonoBehaviour
{
    public static string actualAnswer2;
    public static bool displayingQuestion2 = false;

    public int questionNumber2; // ������������� ��� ������ ��� ������ ��������.
    public int totalQuestions2 = 16; // ������ ������� ���������.
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

                    QuestionDis.newQuestion2 = "���� ��� ��� �������� ������� ������� �� \"Hello World!\" ���� �����;";
                    QuestionDis.newA2 = "�. print(\"Hello World\");";
                    QuestionDis.newB2 = "�. printf(\"Hello World!\");";
                    QuestionDis.newC2 = "�. printf(\"Hello World!\")";
                    QuestionDis.newD2 = "�. printf(Hello World!);";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 2)
                {
                    QuestionDis.newQuestion2 = "����� ���� ��������� �������������� ��� ��� ������ �������� ����������;";
                    QuestionDis.newA2 = "�. char";
                    QuestionDis.newB2 = "�. float";
                    QuestionDis.newC2 = "�. int";
                    QuestionDis.newD2 = "�. double";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 3)
                {
                    QuestionDis.newQuestion2 = "����� ���� ��������� �������������� ��� ��� ������ ����������� ����������;";
                    QuestionDis.newA2 = "�. char";
                    QuestionDis.newB2 = "�. float";
                    QuestionDis.newC2 = "�. int";
                    QuestionDis.newD2 = "�. ������ ��� �� ��������";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 4)
                {
                    QuestionDis.newQuestion2 = "���� ��������� �������� �������������� ��� �� ��������� ������;";
                    QuestionDis.newA2 = "�. \\n";
                    QuestionDis.newB2 = "�. \\b";
                    QuestionDis.newC2 = "�. \\t";
                    QuestionDis.newD2 = "�. \\\"";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 5)
                {
                    QuestionDis.newQuestion2 = "���� ��� ��� �������� ������� �������� ���� ������� ������ ��� ��� ���������� ���� ��������� i;";
                    QuestionDis.newA2 = "�. scanf(\"%d\",&i)";
                    QuestionDis.newB2 = "�. scan(\"%d\", &i);";
                    QuestionDis.newC2 = "�. scanf(\"%f\", &i);";
                    QuestionDis.newD2 = "�. scanf(\"%d\", &i);";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 6)
                {
                    QuestionDis.newQuestion2 = "���� ��� ��� �������� ������� ������� ���� ���������� ������;";
                    QuestionDis.newA2 = "�. float i";
                    QuestionDis.newB2 = "�. int i";
                    QuestionDis.newC2 = "�. float i;";
                    QuestionDis.newD2 = "�. int i;";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 7)
                {
                    QuestionDis.newQuestion2 = "���� ��� ��� �������� ������� ������� ��� ��������� �� �������;";
                    QuestionDis.newA2 = "�. int x;";
                    QuestionDis.newB2 = "�. const int x;";
                    QuestionDis.newC2 = "�. const x = 5;";
                    QuestionDis.newD2 = "�. const int x = 5;";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 8)
                {
                    QuestionDis.newQuestion2 = "����� ��� ��� �������� ������� ������� ��� �����������;";
                    QuestionDis.newA2 = "�. #define SIZE 100;";
                    QuestionDis.newB2 = "�. #define SIZE;";
                    QuestionDis.newC2 = "�. #define SIZE 100";
                    QuestionDis.newD2 = "�. #define SIZE";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 9)
                {
                    QuestionDis.newQuestion2 = "���� ����� � ������ ��� �������� ������������; \r\n #include <stdio.h>\r\nint main () {\r\n\tprintf(\"Hello\\n\");\r\n\tprintf(\"World\");\r\n\treturn 0;\r\n};";
                    QuestionDis.newA2 = "�. Hello\r\n   World";
                    QuestionDis.newB2 = "�. Hello World";
                    QuestionDis.newC2 = "�. Hello\tworld";
                    QuestionDis.newD2 = "�. \"Hello\" \"World\"";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 10)
                {
                    QuestionDis.newQuestion2 = "���� ����� � ������ ��� �������� ������������;\r\n#inlude <stdio.h>\r\nint main() {\r\n\tint x = 20, y = 10;\r\n\tprintf(\"%d + %d = %d\\n\", x, y, x + y);\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "�. %d + %d = %d";
                    QuestionDis.newB2 = "�. x + y = x + y";
                    QuestionDis.newC2 = "�. 20 + 10 = 30";
                    QuestionDis.newD2 = "�. x + y = 30";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 11)
                {
                    QuestionDis.newQuestion2 = "���� � ������ ��� �������� ������������;\r\n#include <stdio.h>\r\nint main() {\r\n\tfloat x = 1.2365;\r\n\tprintf(\"Value = %f\\n\", x);\r\n\tprintf(\"Value = %.2f\\n\", x);\r\n\tprintf(\"Value = %.*f\\n\", 3, x);\r\n\tprintf(\"Value = %.f\\n\", x);\r\n\treturn 0;\r\n};";
                    QuestionDis.newA2 = "�. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 1;";
                    QuestionDis.newB2 = "�. Value = 1.2365\r  Value = 1.24\r\n  Value = 1.23\r\t   Value = 0.1";
                    QuestionDis.newC2 = "�. Value = 1.236500\r   Value = 1.24\r\n  Value = 1.23\r\t   Value = 1";
                    QuestionDis.newD2 = "�. Value = 1.236500\r   Value = 1.24\r\n   Value = 1.237\r\t   Value = 0.1";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 12)
                {
                    QuestionDis.newQuestion2 = "����� ��� ���� �������� �������� ��������������� ��� ��� �������� ����� �� ��� ���������;";
                    QuestionDis.newA2 = "�. ->";
                    QuestionDis.newB2 = "�. <-";
                    QuestionDis.newC2 = "�. =";
                    QuestionDis.newD2 = "�. ==";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 13)
                {
                    QuestionDis.newQuestion2 = "���� �� ����� �� ���������� ��� ������ 3/2 �� ��� �� ��� ������� ����� ��������;";
                    QuestionDis.newA2 = "�. 1.5";
                    QuestionDis.newB2 = "�. 1.0";
                    QuestionDis.newC2 = "�. 1";
                    QuestionDis.newD2 = "�. ������ ��� �� ��������";
                    actualAnswer2 = "�";
                }

                if (questionNumber2 == 14)
                {
                    QuestionDis.newQuestion2 = "���� �� ����� � ������ ��� �������� ������������ ;\r\n#include <stdio.h>\r\nint main() {\r\n\tint x = 5;\r\n\tx++;\r\n\tprintf(\"%d\\n\", x);\r\n\treturn 0;\r\n}";
                    QuestionDis.newA2 = "�. 5";
                    QuestionDis.newB2 = "�. 6";
                    QuestionDis.newC2 = "�. 7";
                    QuestionDis.newD2 = "�. x++";
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
