using TMPro;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class WoodPileScript : MonoBehaviour
{

    public GameObject particles;
    public Items itemType = Items.Wood_stack; // Type of item to be added to the inventory

    private void OnMouseDown()
    {
        // Check if the left mouse button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Add wood to the player's inventory
            InventoryControllerScript.Add(itemType);

            // Destroy the wood pile object
            particles.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
