using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MedievalEuropeScript : MonoBehaviour
{
    //The Medieval Europe information card (GameObject)
    public GameObject europeCard;

    //The yellow semicirle colour (Material)
    public Material highlightedMaterial;

    //The Medieval Europe semicircle on globe (Renderer)
    public Renderer renderer;

    //The place where the button sound effect comes from (AudioSource)
    public AudioSource audioSource;

    //This function is called when Medieval Europe is clicked on the globe
    void OnMouseDown()
    {
        //Opens the Medieval Europe information card
        europeCard.SetActive(true);

        //Makes the red semicircle of Medieval Europe turn yellow
        renderer.material = highlightedMaterial;

        //Play the button sound effect that is located within the "audioSource"
        audioSource.Play();
    }
}
