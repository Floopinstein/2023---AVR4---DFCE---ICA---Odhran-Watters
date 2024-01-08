using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{

    public PlayerInventory PlayerInventory; 
    public GameObject ItemCrossout;



    //When object clicked
    private void OnMouseDown()
    {
        //Detects objects tag to know what it is and to set its boolean to true in the inventory
        if(gameObject.tag.Equals("Food"))
            {
            //Set has Item to true in inventory
            PlayerInventory.HasItem1 = true; 
            //Crossout on UI
            ItemCrossout.SetActive(true);
            //Remove object from scene
            UnityEngine.Object.Destroy(this.gameObject);
            }

        if(gameObject.tag.Equals("Water"))
            {
            PlayerInventory.HasItem2 = true; 
            ItemCrossout.SetActive(true);
            UnityEngine.Object.Destroy(this.gameObject);
            }

        if(gameObject.tag.Equals("Medicine"))
            {
            PlayerInventory.HasItem3 = true;
            ItemCrossout.SetActive(true);
            UnityEngine.Object.Destroy(this.gameObject);
            }

        if(gameObject.tag.Equals("Pots"))
            {
            PlayerInventory.HasItem4 = true;
            ItemCrossout.SetActive(true);
            UnityEngine.Object.Destroy(this.gameObject);
            }
    }

}
