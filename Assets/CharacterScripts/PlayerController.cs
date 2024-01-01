using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
 
 public NavMeshAgent agent;
 public Camera PlayerCamera;


    // Update is called once per frame
    void Update()
    {
        //Get Left Mouse Input
        if (Input.GetMouseButtonDown(0)){
            
            //Get Where player clicks using game camera and return it as a ray
            Ray MouseRay = PlayerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //If players clicks on a suitable location, set as the characters destination
            if (Physics.Raycast(MouseRay, out hit)){
                agent.SetDestination(hit.point);
            }
        }
    }


}
