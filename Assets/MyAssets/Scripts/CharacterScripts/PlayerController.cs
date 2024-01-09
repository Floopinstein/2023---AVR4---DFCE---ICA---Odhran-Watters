using UnityEngine;
using UnityEngine.AI;


/*Character Movement in Unity 3D | New Input System + Root Motion Explained (2020) YouTube.
YouTube. Available at: https://www.youtube.com/watch?v=IurqiqduMVQ&ab_channel=iHeartGameDev (Accessed: 1 January 2024).
Using Line Numbers: 21, 56-64.

Piccolo, M. L. (2022) Unity : use Raycast for move the Player,
Medium. Medium. Available at: https://matteolopiccolo.medium.com/unity-use-raycast-for-move-the-player-64319f711cbf
(Accessed: 9 January 2024).
Using Line Numbers: 33-42
*/

public class PlayerController : MonoBehaviour
{
 
 Animator animator;
 public bool IsMoving = false;

 public NavMeshAgent agent;
 public Camera PlayerCamera;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get Left Mouse Input
        if (Input.GetMouseButtonDown(0)){
            
            //Get Where player clicks using game camera and return it as a ray
            Ray MouseRay = PlayerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //If players clicks on a suitable location, set as the characters destination
            if (Physics.Raycast(MouseRay, out hit))
            {
                agent.SetDestination(hit.point);
                //Set isMoving to true to enable animation
                IsMoving = true;
            }
        }

              if (agent.remainingDistance <= 0.05)
            {
                //Set isMoving to False to stop animation
                IsMoving = false;
            }


        //Sets the Boolean in animator to true and false to enable or diable the walking animation
        if (IsMoving == true)
        {
            animator.SetBool("IsWalking", true);
        }

        if (IsMoving == false)
        {
            animator.SetBool("IsWalking", false);
        }

    }


}
