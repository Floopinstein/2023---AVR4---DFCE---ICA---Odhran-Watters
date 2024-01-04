using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    public Transform playerTransform; 
    public Vector3 offset; 

    void Update()
    {
        //Set the Camera to follow the player with an offset for 3rd person view
        transform.position = playerTransform.position + offset;
    }

}
