using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadPageScript : MonoBehaviour
{
  
    public GameObject Paper; 

    //When left click on page
    void OnMouseDown()
    {
        if (Paper != null)
        {
            //Set the Paper UI as active
            Paper.SetActive(true); 
        }
    }

}