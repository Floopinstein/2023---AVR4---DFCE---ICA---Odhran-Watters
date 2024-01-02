using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AnimationStateContoller : MonoBehaviour
{

    public NavMeshAgent agent;
    public Camera PlayerCamera;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator =  GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetMouseButtonDown(0);

         if (forwardPressed){
            
            animator.SetBool("isWalking", true);


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
