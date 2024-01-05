using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;

public class DoorAnimationScript : MonoBehaviour
{

    public Vector3 MoveBy;
    public float RotateBy;

    
    [SerializeField]
    private NavMeshSurface surface; 
   
   //When player overlaps with the doors trigger box
    void OnTriggerEnter(Collider other)
    {
        print("DoorOpen");
        //Door moves up
        transform.position += MoveBy;
        transform.Rotate (RotateBy, 0, 0);
        surface.BuildNavMesh();

    }

    void OnTriggerExit(Collider other)
    {
        print("DoorClose");
        //Door moves down
        transform.position -= MoveBy;
        transform.Rotate (-RotateBy, 0, 0);
        surface.BuildNavMesh();

    }


}


