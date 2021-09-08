using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarlyImperialChinaScript : MonoBehaviour
{
    //The Early Imperial China information card (GameObject)
    public GameObject chinaCard;

    //The yellow semicirle colour (Material)
    public Material highlightedMaterial;

    //The Early Imperial China semicircle on globe (Renderer)
    public Renderer renderer;

    //The place where the button sound effect comes from (AudioSource)
    public AudioSource audioSource;

    //This function is called when Early Imperial China is clicked on the globe
    void OnMouseDown()
    {
        //Opens the Early Imperial China information card
        chinaCard.SetActive(true);

        //Makes the red semicircle of Early Imperial China turn yellow
        renderer.material = highlightedMaterial;

        //Play the button sound effect that is located within the "audioSource"
        audioSource.Play();
    }
}
