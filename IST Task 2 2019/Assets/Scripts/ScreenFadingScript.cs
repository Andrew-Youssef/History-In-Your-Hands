using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenFadingScript : MonoBehaviour
{
    //The animator controller
    public Animator animator;

    //These functions are called when the user wants to trigger the fade that goes into the Ancient Egypt animations
    public void FadeToEgyptScreen()
    {
        animator.SetTrigger("Fade Out To Egypt");
    }

    public void FadeToEgyptAreaScreen()
    {
        animator.SetTrigger("Fade Out To Egypt Area");
    }

    public void FadeToPyramidScreen()
    {
        animator.SetTrigger("Fade Out To Pyramid");
    }

    public void FadeToMummyScreen()
    {
        animator.SetTrigger("Fade Out To Mummy");
    }

    //These functions are called when the user wants to trigger the fade that goes into the Early Imperial China animations
    public void FadeToChinaScreen()
    {
        animator.SetTrigger("Fade Out To China");
    }

    public void FadeToChinaAreaScreen()
    {
        animator.SetTrigger("Fade Out To China Area");
    }

    public void FadeToKingYuTheGreatScreen()
    {
        animator.SetTrigger("Fade Out To King");
    }

    public void FadeToOracleBonesScreen()
    {
        animator.SetTrigger("Fade Out To Bone");
    }

    //These functions are called when the user wants to trigger the fade that goes into the Medieval Europe animations
    public void FadeToEuropeScreen()
    {
        animator.SetTrigger("Fade Out To Europe");
    }

    public void FadeToEuropeAreaScreen()
    {
        animator.SetTrigger("Fade Out To Europe Area");
    }

    public void FadeToSpearScreen()
    {
        animator.SetTrigger("Fade Out To Spear");
    }

    public void FadeToRatScreen()
    {
        animator.SetTrigger("Fade Out To Rat");
    }

    //These functions are called when the user wants to trigger the fade that goes into the Aztec Empire animations
    public void FadeToAztecScreen()
    {
        animator.SetTrigger("Fade Out To Aztec");
    }

    public void FadeToAztecAreaScreen()
    {
        animator.SetTrigger("Fade Out To Aztec Area");
    }

    public void FadeToTempleScreen()
    {
        animator.SetTrigger("Fade Out To Temple");
    }

    public void FadeToHuitzilopochtliScreen()
    {
        animator.SetTrigger("Fade Out To Huitzilopochtli");
    }

    //These functions are called when the user wants to trigger the fade that goes into the Quiz animations

    public void FadeToQuiz()
    {
        animator.SetTrigger("Fade Out To Minigame");
    }

    public void FadeToQuestion1()
    {
        animator.SetTrigger("Fade Out To Question 1");
    }

    public void FadeToQuestion2()
    {
        animator.SetTrigger("Fade Out To Question 2");
    }

    public void FadeToQuestion3()
    {
        animator.SetTrigger("Fade Out To Question 3");
    }

    public void FadeToQuestion4()
    {
        animator.SetTrigger("Fade Out To Question 4");
    }

    public void FadeToQuestion5()
    {
        animator.SetTrigger("Fade Out To Question 5");
    }

    public void FadeToQuestion6()
    {
        animator.SetTrigger("Fade Out To Question 6");
    }

    public void FadeToQuestion7()
    {
        animator.SetTrigger("Fade Out To Question 7");
    }

    public void FadeToQuestion8()
    {
        animator.SetTrigger("Fade Out To Question 8");
    }

    public void FadeToResultsScreen()
    {
        animator.SetTrigger("Fade Out To Results");
    }

    //These functions are called when the user wants to trigger the fade that goes into the General animations
    public void FadeToStartScreen()
    {
        animator.SetTrigger("Fade Out To Start");
    }

    public void FadeToCreditsScreen()
    {
        animator.SetTrigger("Fade Out To Credits");
    }

    public void FadeToLogScreen()
    {
        animator.SetTrigger("Fade Out To Log");
    }

    public void WhenFadeFinishes()
    {
        SceneManager.LoadScene("Selection Screen");
    }

    public void FadeToDifferentScreens()
    {
        animator.SetTrigger("Fade Out");
    }



    //These functions are called when the animations finish and the scenes are changed
    
    //Ancient Egypt
    public void GoToAncientEgyptTeleporterVideo()
    {
        SceneManager.LoadScene("Ancient Egypt Teleporter Screen");
    }

    public void GoToAncientEgyptAreaScreen()
    {
        SceneManager.LoadScene("Ancient Egypt Area Screen");
    }

    public void GoToPyramidScreen()
    {
        SceneManager.LoadScene("Pyramid Screen");
    }

    public void GoToMummyScreen()
    {
        SceneManager.LoadScene("Mummy Screen");
    }

    //Early Imperial China
    public void GoToEarlyImperialChinaTeleporterVideo()
    {
        SceneManager.LoadScene("Early Imperial China Teleporter Screen");
    }

    public void GoToEarlyImperialChinaAreaScreen()
    {
        SceneManager.LoadScene("Early Imperial China Area Screen");
    }

    public void GoToKingYuTheGreatScreen()
    {
        SceneManager.LoadScene("King Yu The Great Screen");
    }

    public void GoToOracleBonesScreen()
    {
        SceneManager.LoadScene("Oracle Bones Screen");
    }

    //Medieval Europe
    public void GoToMedievalEuropeTeleporterVideo()
    {
        SceneManager.LoadScene("Medieval Europe Teleporter Screen");
    }

    public void GoToMedievalEuropeAreaScreen()
    {
        SceneManager.LoadScene("Medieval Europe Area Screen");
    }

    public void GoToSpearScreen()
    {
        SceneManager.LoadScene("Spear Screen");
    }

    public void GoToRatScreen()
    {
        SceneManager.LoadScene("Rat Screen");
    }

    //The Aztec Empire
    public void GoToAztecEmpireTeleporterVideo()
    {
        SceneManager.LoadScene("Aztec Empire Teleporter Screen");
    }

    public void GoToAztecEmpireAreaScreen()
    {
        SceneManager.LoadScene("Aztec Empire Area Screen");
    }

    public void GoToTheGreatTempleScreen()
    {
        SceneManager.LoadScene("The Great Temple Screen");
    }

    public void GoToHuitzilopochtliScreen()
    {
        SceneManager.LoadScene("Huitzilopochtli Screen");
    }

    //Quiz
    public void GoToQuiz()
    {
        SceneManager.LoadScene("Quiz Starting Screen");
    }

    public void GoToQuestion1()
    {
        SceneManager.LoadScene("Question01");
    }

    public void GoToQuestion2()
    {
        SceneManager.LoadScene("Question02");
    }

    public void GoToQuestion3()
    {
        SceneManager.LoadScene("Question03");
    }

    public void GoToQuestion4()
    {
        SceneManager.LoadScene("Question04");
    }

    public void GoToQuestion5()
    {
        SceneManager.LoadScene("Question05");
    }

    public void GoToQuestion6()
    {
        SceneManager.LoadScene("Question06");
    }

    public void GoToQuestion7()
    {
        SceneManager.LoadScene("Question07");
    }

    public void GoToQuestion8()
    {
        SceneManager.LoadScene("Question08");
    }

    public void GoToResultsScreen()
    {
        SceneManager.LoadScene("Results Screen");
    }

    //General
    public void GoToStartScreen()
    {
        SceneManager.LoadScene("Starting Screen");
    }

    public void GoToCreditsScreen()
    {
        SceneManager.LoadScene("Credits Screen");
    }

    public void GoToLogScreen()
    {
        SceneManager.LoadScene("Log Screen");
    }
}
