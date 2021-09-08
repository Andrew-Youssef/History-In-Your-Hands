using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OracleBonesScript : MonoBehaviour
{
    //The animation controller (GameObject)
    public GameObject screenFader;

    //The place where the button sound effect comes from (AudioSource)
    public AudioSource audioSource;

    //This function is called when Oracle Bones is clicked within Early Imperial China
    void OnMouseDown()
    {
        //Calls the "FadeToOracleBonesScreen" function from the "ScreenFadingScript" inside the "screenFader" GameObject
        screenFader.GetComponent<ScreenFadingScript>().FadeToOracleBonesScreen();

        //Play the button sound effect that is located within the "audioSource"
        audioSource.Play();
    }
}
