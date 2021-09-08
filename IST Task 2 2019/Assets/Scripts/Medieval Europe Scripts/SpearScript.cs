using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpearScript : MonoBehaviour
{
    //The animation controller (GameObject)
    public GameObject screenFader;

    //The place where the button sound effect comes from (AudioSource)
    public AudioSource audioSource;

    //This function is called when the Spear is clicked within Medieval Europe
    void OnMouseDown()
    {
        //Calls the "FadeToSpearScreen" function from the "ScreenFadingScript" inside the "screenFader" GameObject
        screenFader.GetComponent<ScreenFadingScript>().FadeToSpearScreen();

        //Play the button sound effect that is located within the "audioSource"
        audioSource.Play();
    }
}
