using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticEasterEggScript : MonoBehaviour
{
    ////Easter Eggs (Boolean)
    static public bool firstEggFound;
    static public bool secondEggFound;
    static public bool thirdEggFound;
    static public bool fourthEggFound;

    //Easter Eggs (GameObject)
    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;
    public GameObject egg4;

    //Easter Egg Award (GameObject)
    public GameObject award;

    //Amount of eggs found (Text)
    public Text amountOfEggsFoundText;

    //Amount of eggs found (Integer)
    static public float amountOfEggsFoundFloat;

    //This function is called when the scene loads
    public void Start()
    {
        //If all four of the easter eggs are found, show the award
        if (amountOfEggsFoundFloat == 4)
        {
            award.SetActive(true);
        }

        //If the 1st easter egg is found, make it disappear
        if (firstEggFound == true)
        {
            egg1.SetActive(false);
        }

        //If the 2nd easter egg is found, make it disappear
        if (secondEggFound == true)
        {
            egg2.SetActive(false);
        }

        //If the 3rd easter egg is found, make it disappear
        if (thirdEggFound == true)
        {
            egg3.SetActive(false);
        }

        //If the 4th easter egg is found, make it disappear
        if (fourthEggFound == true)
        {
            egg4.SetActive(false);
        }

        //This helps in the testing stage, by showing the amount of easter eggs found in the console
        Debug.Log(amountOfEggsFoundFloat);

        //In the credits, make it show the amount of easter eggs found out of 4
        amountOfEggsFoundText.text = amountOfEggsFoundFloat + " / 4";

        //If there is a glitch and the amount of easter eggs found somehow becomes over 4, make it equal 4
        if (amountOfEggsFoundFloat > 4)
        {
            amountOfEggsFoundFloat = 4;
        }
    }

    //This function is called if the 1st easter egg is found
    public void FirstEggFound()
    {
        //Make the "firstEggFound" boolean equal true
        firstEggFound = true;

        //Increase the "amountOfEggsFoundFloat" by 1
        amountOfEggsFoundFloat++;

        //Make the 1st easter egg disappear
        egg1.SetActive(false);
    }

    //This function is called if the 2nd easter egg is found
    public void SecondEggFound()
    {
        //Make the "secondEggFound" boolean equal true
        secondEggFound = true;

        //Increase the "amountOfEggsFoundFloat" by 1
        amountOfEggsFoundFloat++;

        //Make the 2nd easter egg disappear
        egg2.SetActive(false);
    }

    //This function is called if the 3rd easter egg is found
    public void ThirdEggFound()
    {
        //Make the "thirdEggFound" boolean equal true
        thirdEggFound = true;

        //Increase the "amountOfEggsFoundFloat" by 1
        amountOfEggsFoundFloat++;

        //Make the 3rd easter egg disappear
        egg3.SetActive(false);
    }

    //This function is called if the 4th easter egg is found
    public void FourthEggFound()
    {
        //Make the "fourthEggFound" boolean equal true
        fourthEggFound = true;

        //Increase the "amountOfEggsFoundFloat" by 1
        amountOfEggsFoundFloat++;

        //Make the 4th easter egg disappear
        egg4.SetActive(false);
    }
}
