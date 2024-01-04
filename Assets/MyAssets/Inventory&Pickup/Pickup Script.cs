using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{

    public PlayerInventory PlayerInventory; 

    //When object clicked
    private void OnMouseDown()
    {
        //If the object is
        if(gameObject.tag.Equals("Clickable"))
            {
            //Set has Item to true in inventory
            PlayerInventory.HasItem1 = true; 
            //Remove object from scene
            UnityEngine.Object.Destroy(this.gameObject);
            }
    }

}
