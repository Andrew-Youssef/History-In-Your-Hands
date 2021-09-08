using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MummyScript : MonoBehaviour
{
    //The animation controller (GameObject)
    public GameObject screenFader;

    //The place where the button sound effect comes from (AudioSource)
    public AudioSource audioSource;

    //This function is called when the Mummy is clicked within Ancient Egypt
    void OnMouseDown()
    {
        //Calls the "FadeToMummyScreen" function from the "ScreenFadingScript" inside the "screenFader" GameObject
        screenFader.GetComponent<ScreenFadingScript>().FadeToMummyScreen();

        //Play the button sound effect that is located within the "audioSource"
        audioSource.Play();
    }
}
