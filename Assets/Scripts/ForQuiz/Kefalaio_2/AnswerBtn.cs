using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBtn : MonoBehaviour
{
    public GameObject answerDbackBlue2; // Blue is waiting
    public GameObject answerDbackGreen2; // Green is correct
    public GameObject answerDbackRed2; // Red is wrong

    public GameObject answerCbackBlue2; // Blue is waiting
    public GameObject answerCbackGreen2; // Green is correct
    public GameObject answerCbackRed2; // Red is wrong

    public GameObject answerBbackBlue2; // Blue is waiting
    public GameObject answerBbackGreen2; // Green is correct
    public GameObject answerBbackRed2; // Red is wrong

    public GameObject answerAbackBlue2; // Blue is waiting
    public GameObject answerAbackGreen2; // Green is correct
    public GameObject answerAbackRed2; // Red is wrong

    public GameObject answerD2;
    public GameObject answerC2;
    public GameObject answerB2;
    public GameObject answerA2;

    public AudioSource correctFX2;
    public AudioSource wrongFX2;

    public GameObject currentScore2;
    public GameObject currentQuestion2;
    public int curQuestion2 = 0;

    public int totalQuestions2 = 11;
    public int scoreValue2;
    public int bestScore2 = 55;
    public GameObject score2;
    public GameObject rightAnswer2;
    public GameObject wrongAnswer2;
    public int correctAnswer2 = 0;
    public int incorrectAnswer2 = 0;

    public EndPanelController endPanelController;

    public void EndQuiz()
    {
        // Καλέστε τη μέθοδο ShowEndPanel από το σενάριο EndPanelController
        endPanelController.ShowResultPanel();
    }


    void Update()
    {
        currentScore2.GetComponent<Text>().text = "SCORE: " + scoreValue2;
        currentQuestion2.GetComponent<Text>().text = curQuestion2 + " / " + totalQuestions2;
        score2.GetComponent<Text>().text = "ΣΚΟΡ: " + scoreValue2 + " / " + bestScore2;
        rightAnswer2.GetComponent<Text>().text = "Σωστές Απαντήσεις: " + correctAnswer2;
        wrongAnswer2.GetComponent<Text>().text = "Λάθος Απαντήσεις: " + incorrectAnswer2;


    }



    public void AnswerD()
    {
        if (QuestionGen.actualAnswer2 == "Δ")
        {
            answerDbackGreen2.SetActive(true);
            answerDbackBlue2.SetActive(false);
            correctFX2.Play();
            scoreValue2 += 5;
            correctAnswer2++;
            curQuestion2++;
        }
        else
        {
            answerDbackRed2.SetActive(true);
            answerDbackBlue2.SetActive(false);
            wrongFX2.Play();
            /*if (scoreValue2 == 0)
            {
                scoreValue2 = 0;
            }
            else
            {
                scoreValue2 -= 5;
            } */
            incorrectAnswer2++;
            curQuestion2++;


        }
        answerD2.GetComponent<Button>().enabled = false;
        answerC2.GetComponent<Button>().enabled = false;
        answerB2.GetComponent<Button>().enabled = false;
        answerA2.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }


    public void AnswerC()
    {
        if (QuestionGen.actualAnswer2 == "Γ")
        {
            answerCbackGreen2.SetActive(true);
            answerCbackBlue2.SetActive(false);
            correctFX2.Play();
            scoreValue2 += 5;
            correctAnswer2++;
            curQuestion2++;
        }
        else
        {
            answerCbackRed2.SetActive(true);
            answerCbackBlue2.SetActive(false);
            wrongFX2.Play();
            /*if (scoreValue2 == 0)
            {
                scoreValue2 = 0;
            }
            else
            {
                scoreValue2 -= 5;
            } */
            incorrectAnswer2++;
            curQuestion2++;
        }
        answerD2.GetComponent<Button>().enabled = false;
        answerC2.GetComponent<Button>().enabled = false;
        answerB2.GetComponent<Button>().enabled = false;
        answerA2.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGen.actualAnswer2 == "Β")
        {
            answerBbackGreen2.SetActive(true);
            answerBbackBlue2.SetActive(false);
            correctFX2.Play();
            scoreValue2 += 5;
            correctAnswer2++;
            curQuestion2++;
        }
        else
        {
            answerBbackRed2.SetActive(true);
            answerBbackBlue2.SetActive(false);
            wrongFX2.Play();
            /* if (scoreValue2 == 0)
            {
                scoreValue2 = 0;
            }
            else
            {
                scoreValue2 -= 5;
            } */
            incorrectAnswer2++;
            curQuestion2++;
        }
        answerD2.GetComponent<Button>().enabled = false;
        answerC2.GetComponent<Button>().enabled = false;
        answerB2.GetComponent<Button>().enabled = false;
        answerA2.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerA()
    {
        if (QuestionGen.actualAnswer2 == "Α")
        {
            answerAbackGreen2.SetActive(true);
            answerAbackBlue2.SetActive(false);
            correctFX2.Play();
            scoreValue2 += 5;
            correctAnswer2++;
            curQuestion2++;
        }
        else
        {
            answerAbackRed2.SetActive(true);
            answerAbackBlue2.SetActive(false);
            wrongFX2.Play();
            /*if (scoreValue2 == 0)
            {
                scoreValue2 = 0;
            }
            else
            {
                scoreValue2 -= 5;
            } */
            incorrectAnswer2++;
            curQuestion2++;
        }
        answerD2.GetComponent<Button>().enabled = false;
        answerC2.GetComponent<Button>().enabled = false;
        answerB2.GetComponent<Button>().enabled = false;
        answerA2.GetComponent<Button>().enabled = false;
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


        answerDbackGreen2.SetActive(false);
        answerCbackGreen2.SetActive(false);
        answerBbackGreen2.SetActive(false);
        answerAbackGreen2.SetActive(false);
        answerDbackRed2.SetActive(false);
        answerCbackRed2.SetActive(false);
        answerBbackRed2.SetActive(false);
        answerAbackRed2.SetActive(false);
        answerDbackBlue2.SetActive(true);
        answerCbackBlue2.SetActive(true);
        answerBbackBlue2.SetActive(true);
        answerAbackBlue2.SetActive(true);

        answerD2.GetComponent<Button>().enabled = true;
        answerC2.GetComponent<Button>().enabled = true;
        answerB2.GetComponent<Button>().enabled = true;
        answerA2.GetComponent<Button>().enabled = true;

        QuestionGen.displayingQuestion2 = false;

    }

}