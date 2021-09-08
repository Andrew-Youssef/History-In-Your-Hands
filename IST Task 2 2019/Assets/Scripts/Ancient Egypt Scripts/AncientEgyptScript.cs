using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AncientEgyptScript : MonoBehaviour
{
    //The Ancient Egypt information card (GameObject)
    public GameObject egyptCard;

    //The yellow semicirle colour (Material)
    public Material highlightedMaterial;

    //The Ancient Egypt semicircle on globe (Renderer)
    public Renderer renderer;

    //The place where the button sound effect comes from (AudioSource)
    public AudioSource audioSource;

    //This function is called when Ancient Egypt is clicked on the globe
    void OnMouseDown()
    {
        //Opens the Ancient Egypt information card
        egyptCard.SetActive(true);

        //Makes the red semicircle of Ancient Egypt turn yellow
        renderer.material = highlightedMaterial;

        //Play the button sound effect that is located within the "audioSource"
        audioSource.Play();
    }
}
