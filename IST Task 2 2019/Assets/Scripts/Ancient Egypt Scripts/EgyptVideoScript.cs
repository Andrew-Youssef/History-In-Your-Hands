using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class EgyptVideoScript : MonoBehaviour
{
    //The Ancient Egypt video player (VideoPlayer)
    public VideoPlayer egyptVideoPlayer;

    //The animation controller (GameObject)
    public GameObject screenFader;

    //This function is called when the scene loads
    void Start()
    {
        //Calls the "LoadScene" function when the video contained within the "egyptVideoPlayer" ends
        egyptVideoPlayer.loopPointReached += LoadScene; ;
    }

    //This function is called when the video contained within the "egyptVideoPlayer" ends
    public void LoadScene(VideoPlayer vp)
    {
        //Calls the "FadeToEgyptAreaScreen" function from the "ScreenFadingScript" inside the "screenFader" GameObject
        screenFader.GetComponent<ScreenFadingScript>().FadeToEgyptAreaScreen();
    }
}
