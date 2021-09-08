using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class AztecVideoScript : MonoBehaviour
{
    //The Aztec Empire video player (VideoPlayer)
    public VideoPlayer aztecVideoPlayer;

    //The animation controller (GameObject)
    public GameObject screenFader;

    //This function is called when the scene loads
    void Start()
    {
        //Calls the "LoadScene" function when the video contained within the "aztecVideoPlayer" ends
        aztecVideoPlayer.loopPointReached += LoadScene;
    }

    //This function is called when the video contained within the "aztecVideoPlayer" ends
    void LoadScene(VideoPlayer vp)
    {
        //Calls the "FadeToAztecAreaScreen" function from the "ScreenFadingScript" inside the "screenFader" GameObject
        screenFader.GetComponent<ScreenFadingScript>().FadeToAztecAreaScreen();
    }
}
