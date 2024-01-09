using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{

    public PlayerInventory PlayerInventory; 
    public GameObject EndPaper;

    void OnTriggerEnter(Collider other)
    {
        //If the player has all items in their inventory
        if(PlayerInventory.HasItem1 == true && PlayerInventory.HasItem2 == true && PlayerInventory.HasItem3 == true && PlayerInventory.HasItem4 == true)
        {

            print("GameEnd");
            //Show the end page
            EndPaper.SetActive(true);

        }

    }


}
