using UnityEngine;
using System.Collections;

public class RotatingEarthScript : MonoBehaviour
{
    //The force that is applied to the earth to make it spin (Integer)
    public float speed = 10f;

    //The location parameters of the earth in the 3D space of the scene (Transform)
    public Transform earthSphere;

    //This function is called at a constant rate (FixedUpdate() was used instead of Update() because Update() is called
    //every frame, whereas FixedUpdate() functions at a constant speed and therefore doesn't fluctuate depending on the 
    //amount of frames per second)
    void FixedUpdate()
    {
        //Spins the Earth to the right at the force declared in "speed"
        transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
    }
}