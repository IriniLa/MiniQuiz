using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBut : MonoBehaviour
{
    public GameObject answerDbackBlue4; // Blue is waiting
    public GameObject answerDbackGreen4; // Green is correct
    public GameObject answerDbackRed4; // Red is wrong

    public GameObject answerCbackBlue4; // Blue is waiting
    public GameObject answerCbackGreen4; // Green is correct
    public GameObject answerCbackRed4; // Red is wrong

    public GameObject answerBbackBlue4; // Blue is waiting
    public GameObject answerBbackGreen4; // Green is correct
    public GameObject answerBbackRed4; // Red is wrong

    public GameObject answerAbackBlue4; // Blue is waiting
    public GameObject answerAbackGreen4; // Green is correct
    public GameObject answerAbackRed4; // Red is wrong

    public GameObject answerD4;
    public GameObject answerC4;
    public GameObject answerB4;
    public GameObject answerA4;

    public AudioSource correctFX4;
    public AudioSource wrongFX4;

    public GameObject currentScore4;
    public GameObject currentQuestion4;
    public int curQuestion4 = 0;
    public int scoreValue4;
    public int bestScore4 = 165;
    public GameObject score4;
    public GameObject rightAnswer4;
    public GameObject wrongAnswer4;
    public int correctAnswer4 = 0;
    public int incorrectAnswer4 = 0;
    public int totalQuestions4 = 33;

    public EndPanelController endPanelController;

    public void EndQuiz()
    {
        // Καλέστε τη μέθοδο ShowEndPanel από το σενάριο EndPanelController
        endPanelController.ShowResultPanel();
    }


    void Update()
    {
        currentScore4.GetComponent<Text>().text = "SCORE: " + scoreValue4;
        currentQuestion4.GetComponent<Text>().text = curQuestion4 + " / " + totalQuestions4;
        score4.GetComponent<Text>().text = "ΣΚΟΡ: " + scoreValue4 + " / " + bestScore4;
        rightAnswer4.GetComponent<Text>().text = "Σωστές Απαντήσεις: " + correctAnswer4;
        wrongAnswer4.GetComponent<Text>().text = "Λάθος Απαντήσεις: " + incorrectAnswer4;


    }



    public void AnswerD()
    {
        if (QuestionGene.actualAnswer4 == "Δ")
        {
            answerDbackGreen4.SetActive(true);
            answerDbackBlue4.SetActive(false);
            correctFX4.Play();
            scoreValue4 += 5;
            correctAnswer4++;
            curQuestion4++;
        }
        else
        {
            answerDbackRed4.SetActive(true);
            answerDbackBlue4.SetActive(false);
            wrongFX4.Play();
            /*if (scoreValue4 == 0)
            {
                scoreValue4 = 0;
            }
            else
            {
                scoreValue4 -= 5;
            } */
            incorrectAnswer4++;
            curQuestion4++;


        }
        answerD4.GetComponent<Button>().enabled = false;
        answerC4.GetComponent<Button>().enabled = false;
        answerB4.GetComponent<Button>().enabled = false;
        answerA4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }


    public void AnswerC()
    {
        if (QuestionGene.actualAnswer4 == "Γ")
        {
            answerCbackGreen4.SetActive(true);
            answerCbackBlue4.SetActive(false);
            correctFX4.Play();
            scoreValue4 += 5;
            correctAnswer4++;
            curQuestion4++;
        }
        else
        {
            answerCbackRed4.SetActive(true);
            answerCbackBlue4.SetActive(false);
            wrongFX4.Play();
            /*if (scoreValue4 == 0)
            {
                scoreValue4 = 0;
            }
            else
            {
                scoreValue4 -= 5;
            } */
            incorrectAnswer4++;
            curQuestion4++;
        }
        answerD4.GetComponent<Button>().enabled = false;
        answerC4.GetComponent<Button>().enabled = false;
        answerB4.GetComponent<Button>().enabled = false;
        answerA4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGene.actualAnswer4 == "Β")
        {
            answerBbackGreen4.SetActive(true);
            answerBbackBlue4.SetActive(false);
            correctFX4.Play();
            scoreValue4 += 5;
            correctAnswer4++;
            curQuestion4++;
        }
        else
        {
            answerBbackRed4.SetActive(true);
            answerBbackBlue4.SetActive(false);
            wrongFX4.Play();
            /*if (scoreValue4 == 0)
            {
                scoreValue4 = 0;
            }
            else
            {
                scoreValue4 -= 5;
            } */
            incorrectAnswer4++;
            curQuestion4++;
        }
        answerD4.GetComponent<Button>().enabled = false;
        answerC4.GetComponent<Button>().enabled = false;
        answerB4.GetComponent<Button>().enabled = false;
        answerA4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerA()
    {
        if (QuestionGene.actualAnswer4 == "Α")
        {
            answerAbackGreen4.SetActive(true);
            answerAbackBlue4.SetActive(false);
            correctFX4.Play();
            scoreValue4 += 5;
            correctAnswer4++;
            curQuestion4++;
        }
        else
        {
            answerAbackRed4.SetActive(true);
            answerAbackBlue4.SetActive(false);
            wrongFX4.Play();
            /* if (scoreValue4 == 0)
            {
                scoreValue4 = 0;
            }
            else
            {
                scoreValue4 -= 5;
            } */
            incorrectAnswer4++;
            curQuestion4++;
        }
        answerD4.GetComponent<Button>().enabled = false;
        answerC4.GetComponent<Button>().enabled = false;
        answerB4.GetComponent<Button>().enabled = false;
        answerA4.GetComponent<Button>().enabled = false;
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


        answerDbackGreen4.SetActive(false);
        answerCbackGreen4.SetActive(false);
        answerBbackGreen4.SetActive(false);
        answerAbackGreen4.SetActive(false);
        answerDbackRed4.SetActive(false);
        answerCbackRed4.SetActive(false);
        answerBbackRed4.SetActive(false);
        answerAbackRed4.SetActive(false);
        answerDbackBlue4.SetActive(true);
        answerCbackBlue4.SetActive(true);
        answerBbackBlue4.SetActive(true);
        answerAbackBlue4.SetActive(true);

        answerD4.GetComponent<Button>().enabled = true;
        answerC4.GetComponent<Button>().enabled = true;
        answerB4.GetComponent<Button>().enabled = true;
        answerA4.GetComponent<Button>().enabled = true;

        QuestionGene.displayingQuestion4 = false;

    }

}