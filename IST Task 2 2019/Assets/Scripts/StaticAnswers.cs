using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StaticAnswers : MonoBehaviour
{
    //Questions (Boolean)
    static public bool question1;
    static public bool question2;
    static public bool question3;
    static public bool question4;
    static public bool question5;
    static public bool question6;
    static public bool question7;
    static public bool question8;

    //In the results, these are the areas that show if each question was correct or incorrect (Text)
    public Text question1result;
    public Text question2result;
    public Text question3result;
    public Text question4result;
    public Text question5result;
    public Text question6result;
    public Text question7result;
    public Text question8result;

    //In the results, this is the area that shows the amount of correct questions out of 8 (Text)
    public Text amountOfCorrectAnswersText;

    //This counts how many correct answers the user chooses (Integer)
    static public float amountOfCorrectAnswersFloat;


    //This function is called when the scene loads
    void Start()
    {
        //This helps in the testing stage, by showing the amount of correct answers in the console
        Debug.Log(amountOfCorrectAnswersFloat);

        //In the results, if question 1 was answered correctly then it will state that question 1 was answered "Correct",
        //but if it was answered wrong, then it will show that question 1 was answered "Incorrect"
        if (question1==true)
        {
            question1result.text = "Correct";
        }
        else
        {
            question1result.text = "Incorrect";
        }

        //In the results, if question 2 was answered correctly then it will state that question 2 was answered "Correct",
        //but if it was answered wrong, then it will show that question 2 was answered "Incorrect"
        if (question2 == true)
        {
            question2result.text = "Correct";
        }
        else
        {
            question2result.text = "Incorrect";
        }

        //In the results, if question 3 was answered correctly then it will state that question 3 was answered "Correct",
        //but if it was answered wrong, then it will show that question 3 was answered "Incorrect"
        if (question3 == true)
        {
            question3result.text = "Correct";
        }
        else
        {
            question3result.text = "Incorrect";
        }

        //In the results, if question 4 was answered correctly then it will state that question 4 was answered "Correct",
        //but if it was answered wrong, then it will show that question 4 was answered "Incorrect"
        if (question4 == true)
        {
            question4result.text = "Correct";
        }
        else
        {
            question4result.text = "Incorrect";
        }

        //In the results, if question 5 was answered correctly then it will state that question 5 was answered "Correct",
        //but if it was answered wrong, then it will show that question 5 was answered "Incorrect"
        if (question5 == true)
        {
            question5result.text = "Correct";
        }
        else
        {
            question5result.text = "Incorrect";
        }

        //In the results, if question 6 was answered correctly then it will state that question 6 was answered "Correct",
        //but if it was answered wrong, then it will show that question 6 was answered "Incorrect"
        if (question6 == true)
        {
            question6result.text = "Correct";
        }
        else
        {
            question6result.text = "Incorrect";
        }

        //In the results, if question 7 was answered correctly then it will state that question 7 was answered "Correct",
        //but if it was answered wrong, then it will show that question 7 was answered "Incorrect"
        if (question7 == true)
        {
            question7result.text = "Correct";
        }
        else
        {
            question7result.text = "Incorrect";
        }

        //In the results, if question 8 was answered correctly then it will state that question 8 was answered "Correct",
        //but if it was answered wrong, then it will show that question 8 was answered "Incorrect"
        if (question8 == true)
        {
            question8result.text = "Correct";
        }
        else
        {
            question8result.text = "Incorrect";
        }

        //In the results, it will show the amount of correct answers out of 8
        amountOfCorrectAnswersText.text = "Total:  " + amountOfCorrectAnswersFloat + " / 8";
    }

    //If the user decides to leave or restart the quiz, then this function is called
    public void RestartButton()
    {
        //Each of the questions are set to wrong
        question1 = false;
        question2 = false;
        question3 = false;
        question4 = false;
        question5 = false;
        question6 = false;
        question7 = false;
        question8 = false;

        //The amount of correct answers is set to 0
        amountOfCorrectAnswersFloat = 0;
    }

    //This function is called if the 1st question is answered correctly
    public void Question1IsCorrect()
    {
        //Make the boolean for question 1 equal correct
        question1 = true;

        //Add 1 to the amount of correct answers
        amountOfCorrectAnswersFloat++;
    }

    //This function is called if the 2nd question is answered correctly
    public void Question2IsCorrect()
    {
        //Make the boolean for question 2 equal correct
        question2 = true;

        //Add 1 to the amount of correct answers
        amountOfCorrectAnswersFloat++;
    }

    //This function is called if the 3rd question is answered correctly
    public void Question3IsCorrect()
    {
        //Make the boolean for question 3 equal correct
        question3 = true;

        //Add 1 to the amount of correct answers
        amountOfCorrectAnswersFloat++;
    }

    //This function is called if the 4th question is answered correctly
    public void Question4IsCorrect()
    {
        //Make the boolean for question 4 equal correct
        question4 = true;

        //Add 1 to the amount of correct answers
        amountOfCorrectAnswersFloat++;
    }

    //This function is called if the 5th question is answered correctly
    public void Question5IsCorrect()
    {
        //Make the boolean for question 5 equal correct
        question5 = true;

        //Add 1 to the amount of correct answers
        amountOfCorrectAnswersFloat++;
    }

    //This function is called if the 6th question is answered correctly
    public void Question6IsCorrect()
    {
        //Make the boolean for question 6 equal correct
        question6 = true;

        //Add 1 to the amount of correct answers
        amountOfCorrectAnswersFloat++;
    }

    //This function is called if the 7th question is answered correctly
    public void Question7IsCorrect()
    {
        //Make the boolean for question 7 equal correct
        question7 = true;

        //Add 1 to the amount of correct answers
        amountOfCorrectAnswersFloat++;
    }

    //This function is called if the 8th question is answered correctly
    public void Question8IsCorrect()
    {
        //Make the boolean for question 8 equal correct
        question8 = true;

        //Add 1 to the amount of correct answers
        amountOfCorrectAnswersFloat++;
    }
}
