using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KingYuTheGreatScript : MonoBehaviour
{
    //The animation controller (GameObject)
    public GameObject screenFader;

    //The place where the button sound effect comes from (AudioSource)
    public AudioSource audioSource;

    //This function is called when King Yu The Great is clicked within Early Imperial China
    void OnMouseDown()
    {
        //Calls the "FadeToKingYuTheGreatScreen" function from the "ScreenFadingScript" inside the "screenFader" GameObject
        screenFader.GetComponent<ScreenFadingScript>().FadeToKingYuTheGreatScreen();

        //Play the button sound effect that is located within the "audioSource"
        audioSource.Play();
    }
}
