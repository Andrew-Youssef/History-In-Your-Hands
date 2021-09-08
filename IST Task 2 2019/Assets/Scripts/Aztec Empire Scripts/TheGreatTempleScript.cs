using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheGreatTempleScript : MonoBehaviour
{
    //The animation controller (GameObject)
    public GameObject screenFader;

    //The place where the button sound effect comes from (AudioSource)
    public AudioSource audioSource;

    //This function is called when The Great Temple is clicked within the Aztec Empire
    void OnMouseDown()
    {
        //Calls the "FadeToTempleScreen" function from the "ScreenFadingScript" inside the "screenFader" GameObject
        screenFader.GetComponent<ScreenFadingScript>().FadeToTempleScreen();

        //Play the button sound effect that is located within the "audioSource"
        audioSource.Play();
    }
}
