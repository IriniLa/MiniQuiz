using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBt : MonoBehaviour
{
    public GameObject answerDbackBlue3; // Blue is waiting
    public GameObject answerDbackGreen3; // Green is correct
    public GameObject answerDbackRed3; // Red is wrong

    public GameObject answerCbackBlue3; // Blue is waiting
    public GameObject answerCbackGreen3; // Green is correct
    public GameObject answerCbackRed3; // Red is wrong

    public GameObject answerBbackBlue3; // Blue is waiting
    public GameObject answerBbackGreen3; // Green is correct
    public GameObject answerBbackRed3; // Red is wrong

    public GameObject answerAbackBlue3; // Blue is waiting
    public GameObject answerAbackGreen3; // Green is correct
    public GameObject answerAbackRed3; // Red is wrong

    public GameObject answerD3;
    public GameObject answerC3;
    public GameObject answerB3;
    public GameObject answerA3;

    public AudioSource correctFX3;
    public AudioSource wrongFX3;

    public GameObject currentScore3;
    public GameObject currentQuestion3;
    public int curQuestion3 = 0;
    public int totalQuestions3 = 8;
    public int scoreValue3;
    public int bestScore3 = 40;
    public GameObject score3;
    public GameObject rightAnswer3;
    public GameObject wrongAnswer3;
    public int correctAnswer3 = 0;
    public int incorrectAnswer3 = 0;

    public EndPanelController endPanelController;

    public void EndQuiz()
    {
        // Καλέστε τη μέθοδο ShowEndPanel από το σενάριο EndPanelController
        endPanelController.ShowResultPanel();
    }


    void Update()
    {
        currentScore3.GetComponent<Text>().text = "SCORE: " + scoreValue3;
        currentQuestion3.GetComponent<Text>().text = curQuestion3 + " / " + totalQuestions3;
        score3.GetComponent<Text>().text = "ΣΚΟΡ: " + scoreValue3 + " / " + bestScore3;
        rightAnswer3.GetComponent<Text>().text = "Σωστές Απαντήσεις: " + correctAnswer3;
        wrongAnswer3.GetComponent<Text>().text = "Λάθος Απαντήσεις: " + incorrectAnswer3;


    }



    public void AnswerD()
    {
        if (QuestionG.actualAnswer3 == "Δ")
        {
            answerDbackGreen3.SetActive(true);
            answerDbackBlue3.SetActive(false);
            correctFX3.Play();
            scoreValue3 += 5;
            correctAnswer3++;
            curQuestion3++;
        }
        else
        {
            answerDbackRed3.SetActive(true);
            answerDbackBlue3.SetActive(false);
            wrongFX3.Play();
            if (QuestionG.actualAnswer3 == "Α")
            {
                answerAbackGreen3.SetActive(true);
                answerAbackBlue3.SetActive(false);
            }
            else if (QuestionG.actualAnswer3 == "Β")
            {
                answerBbackGreen3.SetActive(true);
                answerBbackBlue3.SetActive(false);
            }
            else if (QuestionG.actualAnswer3 == "Γ")
            {
                answerCbackGreen3.SetActive(true);
                answerCbackBlue3.SetActive(false);
            }
            else
            {
                answerDbackGreen3.SetActive(true);
                answerDbackBlue3.SetActive(false);
            }
            /*if (scoreValue3 == 0)
            {
                scoreValue3 = 0;
            }
            else
            {
                scoreValue3 -= 5;
            } */
            incorrectAnswer3++;
            curQuestion3++;


        }
        answerD3.GetComponent<Button>().enabled = false;
        answerC3.GetComponent<Button>().enabled = false;
        answerB3.GetComponent<Button>().enabled = false;
        answerA3.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }


    public void AnswerC()
    {
        if (QuestionG.actualAnswer3 == "Γ")
        {
            answerCbackGreen3.SetActive(true);
            answerCbackBlue3.SetActive(false);
            correctFX3.Play();
            scoreValue3 += 5;
            correctAnswer3++;
            curQuestion3++;
        }
        else
        {
            answerCbackRed3.SetActive(true);
            answerCbackBlue3.SetActive(false);
            wrongFX3.Play();
            if (QuestionG.actualAnswer3 == "Α")
            {
                answerAbackGreen3.SetActive(true);
                answerAbackBlue3.SetActive(false);
            }
            else if (QuestionG.actualAnswer3 == "Β")
            {
                answerBbackGreen3.SetActive(true);
                answerBbackBlue3.SetActive(false);
            }
            else if (QuestionG.actualAnswer3 == "Δ")
            {
                answerDbackGreen3.SetActive(true);
                answerDbackBlue3.SetActive(false);
            }
            else
            {
                answerCbackGreen3.SetActive(true);
                answerCbackBlue3.SetActive(false);
            }
            /*if (scoreValue3 == 0)
            {
                scoreValue3 = 0;
            }
            else
            {
                scoreValue3 -= 5;
            } */
            incorrectAnswer3++;
            curQuestion3++;
        }
        answerD3.GetComponent<Button>().enabled = false;
        answerC3.GetComponent<Button>().enabled = false;
        answerB3.GetComponent<Button>().enabled = false;
        answerA3.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionG.actualAnswer3 == "Β")
        {
            answerBbackGreen3.SetActive(true);
            answerBbackBlue3.SetActive(false);
            correctFX3.Play();
            scoreValue3 += 5;
            correctAnswer3++;
            curQuestion3++;
        }
        else
        {
            answerBbackRed3.SetActive(true);
            answerBbackBlue3.SetActive(false);
            wrongFX3.Play();
            if (QuestionG.actualAnswer3 == "Α")
            {
                answerAbackGreen3.SetActive(true);
                answerAbackBlue3.SetActive(false);
            }
            else if (QuestionG.actualAnswer3 == "Γ")
            {
                answerCbackGreen3.SetActive(true);
                answerCbackBlue3.SetActive(false);
            }
            else if (QuestionG.actualAnswer3 == "Δ")
            {
                answerDbackGreen3.SetActive(true);
                answerDbackBlue3.SetActive(false);
            }
            else
            {
                answerBbackGreen3.SetActive(true);
                answerBbackBlue3.SetActive(false);
            }
            /*if (scoreValue3 == 0)
            {
                scoreValue3 = 0;
            }
            else
            {
                scoreValue3 -= 5;
            } */
            incorrectAnswer3++;
            curQuestion3++;
        }
        answerD3.GetComponent<Button>().enabled = false;
        answerC3.GetComponent<Button>().enabled = false;
        answerB3.GetComponent<Button>().enabled = false;
        answerA3.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerA()
    {
        if (QuestionG.actualAnswer3 == "Α")
        {
            answerAbackGreen3.SetActive(true);
            answerAbackBlue3.SetActive(false);
            correctFX3.Play();
            scoreValue3 += 5;
            correctAnswer3++;
            curQuestion3++;
        }
        else
        {
            answerAbackRed3.SetActive(true);
            answerAbackBlue3.SetActive(false);
            if (QuestionG.actualAnswer3 == "Β")
            {
                answerBbackGreen3.SetActive(true);
                answerBbackBlue3.SetActive(false);
            }
            else if (QuestionG.actualAnswer3 == "Γ")
            {
                answerCbackGreen3.SetActive(true);
                answerCbackBlue3.SetActive(false);
            }
            else if (QuestionG.actualAnswer3 == "Δ")
            {
                answerDbackGreen3.SetActive(true);
                answerDbackBlue3.SetActive(false);
            }
            else
            {
                answerAbackGreen3.SetActive(true);
                answerAbackBlue3.SetActive(false);
            }
            wrongFX3.Play();
            /* if (scoreValue3 == 0)
            {
                scoreValue3 = 0;
            }
            else
            {
                scoreValue3 -= 5;
            } */
            incorrectAnswer3++;
            curQuestion3++;
        }
        answerD3.GetComponent<Button>().enabled = false;
        answerC3.GetComponent<Button>().enabled = false;
        answerB3.GetComponent<Button>().enabled = false;
        answerA3.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }



    IEnumerator NextQuestion()
    {
        /*if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<Text>().text = "BEST: " + scoreValue;
        } */
        yield return new WaitForSeconds(2);


        answerDbackGreen3.SetActive(false);
        answerCbackGreen3.SetActive(false);
        answerBbackGreen3.SetActive(false);
        answerAbackGreen3.SetActive(false);
        answerDbackRed3.SetActive(false);
        answerCbackRed3.SetActive(false);
        answerBbackRed3.SetActive(false);
        answerAbackRed3.SetActive(false);
        answerDbackBlue3.SetActive(true);
        answerCbackBlue3.SetActive(true);
        answerBbackBlue3.SetActive(true);
        answerAbackBlue3.SetActive(true);

        answerD3.GetComponent<Button>().enabled = true;
        answerC3.GetComponent<Button>().enabled = true;
        answerB3.GetComponent<Button>().enabled = true;
        answerA3.GetComponent<Button>().enabled = true;

        QuestionG.displayingQuestion3 = false;

    }

}