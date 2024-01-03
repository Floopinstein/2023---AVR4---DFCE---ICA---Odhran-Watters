using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AnimationStateContoller : MonoBehaviour
{

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        //When Mouse button clicked
        if (Input.GetMouseButtonDown(0))
        {
            //Set is walking to true, enabling the walking animation in the animator
            animator.SetBool("IsWalking", true);
          
                //Delay the stop animation by 2 seconds
                StartCoroutine(DelayThenStop(2f));

                IEnumerator DelayThenStop(float delay)
                {
                    //Stop the walking animation after 2 seconds
                    yield return new WaitForSeconds(delay);
                    animator.SetBool("IsWalking", false);
                    
                }

        }

    }
}
