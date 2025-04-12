using System;
using UnityEngine;

public class BasePlateClick : MonoBehaviour
{
    public CampFireScript campfire; // Assign this in Inspector

    void OnMouseDown()
    {
        if (campfire != null)
        {
            if (InventoryControllerScript.Present(Items.Wood_stack))
            {   
                campfire.OnBasePlateClicked();
                InventoryControllerScript.Remove(Items.Wood_stack);
            }
        }
    }
}
