using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ChinaVideoScript : MonoBehaviour
{
    //The Early Imperial China video player (VideoPlayer)
    public VideoPlayer chinaVideoPlayer;

    //The animation controller (GameObject)
    public GameObject screenFader;

    //This function is called when the scene loads
    void Start()
    {
        //Calls the "LoadScene" function when the video contained within the "chinaVideoPlayer" ends
        chinaVideoPlayer.loopPointReached += LoadScene;
    }

    //This function is called when the video contained within the "chinaVideoPlayer" ends
    void LoadScene(VideoPlayer vp)
    {
        //Calls the "FadeToChinaAreaScreen" function from the "ScreenFadingScript" inside the "screenFader" GameObject
        screenFader.GetComponent<ScreenFadingScript>().FadeToChinaAreaScreen();
    }
}
