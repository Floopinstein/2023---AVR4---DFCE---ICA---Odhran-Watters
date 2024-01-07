using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameScript : MonoBehaviour
{

    public PlayerInventory PlayerInventory; 
    public GameObject EndPaper;

    void OnTriggerEnter(Collider other)
    {
        if(PlayerInventory.HasItem1 == true && PlayerInventory.HasItem2 == true && PlayerInventory.HasItem3 == true && PlayerInventory.HasItem4 == true && PlayerInventory.HasItem5 == true)
        {

            print("GameEnd");
            EndPaper.SetActive(true);

        }

    }

    public void QuitGame()
    {
        //Closes the game
        Application.Quit();
    }



}
