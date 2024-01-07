using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadPageScript : MonoBehaviour
{
  
    public GameObject Paper; 

    void OnMouseDown()
    {
        if (Paper != null)
        {
            Paper.SetActive(true); 
        }
    }

}