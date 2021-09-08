using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AztecEmpireScript : MonoBehaviour
{
    //The Aztec Empire information card (GameObject)
    public GameObject aztecCard;

    //The yellow semicirle colour (Material)
    public Material highlightedMaterial;

    //The Ancient Egypt semicircle on globe (Renderer)
    public Renderer renderer;

    //The place where the button sound effect comes from (AudioSource)
    public AudioSource audioSource;

    //This function is called when the Aztec Empire is clicked on the globe
    void OnMouseDown()
    {
        //Opens the Aztec Empire information card
        aztecCard.SetActive(true);

        //Makes the red semicircle of the Aztec Empire turn yellow
        renderer.material = highlightedMaterial;

        //Play the button sound effect that is located within the "audioSource"
        audioSource.Play();
    }
}

