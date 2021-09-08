using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightArrowScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //The force that is applied to the earth to make it spin (Integer)
    public float speed = 10f;

    //This is used to know when to spin to spin the earth, and when not to (Boolean)
    public bool buttonPressed;

    //The location parameters of the earth in the 3D space of the scene (Transform)
    public Transform earthObject;

    //This function is called when the right arrow button is held down
    public void OnPointerDown(PointerEventData eventData)
    {
        //Makes the "buttonPressed" boolean equal true, which makes the earth spin
        buttonPressed = true;
    }

    //This function is called when the right arrow button is let go
    public void OnPointerUp(PointerEventData eventData)
    {
        //Makes the "buttonPressed" boolean equal false, which makes the earth stop spinning
        buttonPressed = false;
    }

    //This function is called at a constant rate (FixedUpdate() was used instead of Update() because Update() is called
    //every frame, whereas FixedUpdate() functions at a constant speed and therefore doesn't fluctuate depending on the 
    //amount of frames per second)
    public void FixedUpdate()
    {
        //If "buttonPressed" is true, then the earth spins to the right at the force declared in "speed"
        if (buttonPressed == true)
        {
            earthObject.transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
        }
    }
}
