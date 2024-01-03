using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AI;

public class DoorAnimationScript : MonoBehaviour
{
   
   //When player overlaps with the doors trigger box
    void OnTriggerEnter(Collider other)
    {
        print("DoorOpen");
        //Door moves up
        transform.position += new Vector3(0, 3, 0);
        //rebuild new navmesh
    }

    void OnTriggerExit(Collider other)
    {
        print("DoorClose");
        //Door moves down
        transform.position += new Vector3(0, -3, 0);
        //rebuild navmesh
    }


}
