using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnswerButtons : MonoBehaviour
{
    public GameObject answerDbackBlue; // Blue is waiting
    public GameObject answerDbackGreen; // Green is correct
    public GameObject answerDbackRed; // Red is wrong

    public GameObject answerCbackBlue; // Blue is waiting
    public GameObject answerCbackGreen; // Green is correct
    public GameObject answerCbackRed; // Red is wrong

    public GameObject answerBbackBlue; // Blue is waiting
    public GameObject answerBbackGreen; // Green is correct
    public GameObject answerBbackRed; // Red is wrong

    public GameObject answerAbackBlue; // Blue is waiting
    public GameObject answerAbackGreen; // Green is correct
    public GameObject answerAbackRed; // Red is wrong

    public GameObject answerD;
    public GameObject answerC;
    public GameObject answerB;
    public GameObject answerA;

    public AudioSource correctFX;
    public AudioSource wrongFX;

    public GameObject currentScore;
    public GameObject currentQuestion;
    public int curQuestion = 0;

    public int totalQuestions = 14;
    public int scoreValue;
    public int bestScore = 70;
    public GameObject score;
    public GameObject rightAnswer;
    public GameObject wrongAnswer;
    public int correctAnswer = 0;
    public int incorrectAnswer = 0;
    public GameObject feedback;
    

    public EndPanelController endPanelController;

    public void EndQuiz()
    {
        // Καλέστε τη μέθοδο ShowEndPanel από το σενάριο EndPanelController
        endPanelController.ShowResultPanel();
    }


    void Update()
    {
            if (scoreValue >= 55)
            {
                feedback.GetComponent<Text>().text = "Συγχαρητήρια!";
            }
            else if ( scoreValue < 55 && scoreValue >= 35)
            {
                feedback.GetComponent<Text>().text = "Καλή προσπάθεια!";
            }
            else if (scoreValue < 35)
            {
                feedback.GetComponent<Text>().text = "Προσπάθησε  ξανά! ";
            }
            else
            {
                feedback.GetComponent<Text>().text = " ";
            }


                currentScore.GetComponent<Text>().text = "SCORE: " + scoreValue;
            currentQuestion.GetComponent<Text>().text = curQuestion + " / " + totalQuestions;
            score.GetComponent<Text>().text = "ΣΚΟΡ: " + scoreValue + " / " + bestScore;
            rightAnswer.GetComponent<Text>().text = "Σωστές Απαντήσεις: " + correctAnswer;
            wrongAnswer.GetComponent<Text>().text = "Λάθος Απαντήσεις: " + incorrectAnswer;

    }


    public void  AnswerD()
    {
        if (QuestionGenerate.actualAnswer == "Δ")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            correctAnswer++;
            curQuestion++;
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
            wrongFX.Play();
            if (QuestionGenerate.actualAnswer == "Α")
            {
                answerAbackGreen.SetActive(true);
                answerAbackBlue.SetActive(false);
            }
            else if (QuestionGenerate.actualAnswer == "Β")
            {
                answerBbackGreen.SetActive(true);
                answerBbackBlue.SetActive(false);
            }
            else if (QuestionGenerate.actualAnswer == "Γ")
            {
                answerCbackGreen.SetActive(true);
                answerCbackBlue.SetActive(false);
            }
            else
            {
                answerDbackGreen.SetActive(true);
                answerDbackBlue.SetActive(false);
            }
            /*if (scoreValue == 0)
            {
                scoreValue = 0;
            }
            else
            {
                scoreValue -= 5;
            } */
            incorrectAnswer++;
            curQuestion++;


        }
        answerD.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerA.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }


    public void AnswerC()
    {
        if (QuestionGenerate.actualAnswer == "Γ")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            correctAnswer++;
            curQuestion++;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            wrongFX.Play();
            if (QuestionGenerate.actualAnswer == "Α")
            {
                answerAbackGreen.SetActive(true);
                answerAbackBlue.SetActive(false);
            }
            else if (QuestionGenerate.actualAnswer == "Β")
            {
                answerBbackGreen.SetActive(true);
                answerBbackBlue.SetActive(false);
            }
            else if (QuestionGenerate.actualAnswer == "Δ")
            {
                answerDbackGreen.SetActive(true);
                answerDbackBlue.SetActive(false);
            }
            else
            {
                answerCbackGreen.SetActive(true);
                answerCbackBlue.SetActive(false);
            }
            /*if(scoreValue == 0)
            {
                scoreValue = 0;
            }
            else
            {
                scoreValue -= 5;
            } */
            incorrectAnswer++;
            curQuestion++;
        }
        answerD.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerA.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenerate.actualAnswer == "Β")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            correctAnswer++;
            curQuestion++;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            wrongFX.Play();
            if (QuestionGenerate.actualAnswer == "Α")
            {
                answerAbackGreen.SetActive(true);
                answerAbackBlue.SetActive(false);
            }
            else if (QuestionGenerate.actualAnswer == "Γ")
            {
                answerCbackGreen.SetActive(true);
                answerCbackBlue.SetActive(false);
            }
            else if (QuestionGenerate.actualAnswer == "Δ")
            {
                answerDbackGreen.SetActive(true);
                answerDbackBlue.SetActive(false);
            }
            else
            {
                answerBbackGreen.SetActive(true);
                answerBbackBlue.SetActive(false);
            }
            /*if (scoreValue == 0)
            {
                scoreValue = 0;
            }
            else
            {
                scoreValue -= 5;
            } */
            incorrectAnswer++;
            curQuestion++;
        }
        answerD.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerA.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerA()
    {
        if (QuestionGenerate.actualAnswer == "Α")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
            correctAnswer++;
            curQuestion++;
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            wrongFX.Play();
            if (QuestionGenerate.actualAnswer == "Β")
            {
                answerBbackGreen.SetActive(true);
                answerBbackBlue.SetActive(false);
            }
            else if (QuestionGenerate.actualAnswer == "Γ")
            {
                answerCbackGreen.SetActive(true);
                answerCbackBlue.SetActive(false);
            }
            else if (QuestionGenerate.actualAnswer == "Δ")
            {
                answerDbackGreen.SetActive(true);
                answerDbackBlue.SetActive(false);
            }
            else
            {
                answerAbackGreen.SetActive(true);
                answerAbackBlue.SetActive(false);
            }
            /* if (scoreValue == 0)
            {
                scoreValue = 0;
            }
            else
            {
                scoreValue -= 5;
            } */
            incorrectAnswer++;
            curQuestion++;
        }
        answerD.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerA.GetComponent<Button>().enabled = false;
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

        
            answerDbackGreen.SetActive(false);
            answerCbackGreen.SetActive(false);
            answerBbackGreen.SetActive(false);
            answerAbackGreen.SetActive(false);
            answerDbackRed.SetActive(false);
            answerCbackRed.SetActive(false);
            answerBbackRed.SetActive(false);
            answerAbackRed.SetActive(false);
            answerDbackBlue.SetActive(true);
            answerCbackBlue.SetActive(true);
            answerBbackBlue.SetActive(true);
            answerAbackBlue.SetActive(true);

            answerD.GetComponent<Button>().enabled = true;
            answerC.GetComponent<Button>().enabled = true;
            answerB.GetComponent<Button>().enabled = true;
            answerA.GetComponent<Button>().enabled = true;

            QuestionGenerate.displayingQuestion = false;
        
    }

}
   
