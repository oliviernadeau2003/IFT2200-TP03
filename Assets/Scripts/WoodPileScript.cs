using UnityEngine;

public class WoodPileScript : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        // Check if the left mouse button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Add wood to the player's inventory

            // Destroy the wood pile object
            gameObject.SetActive(false);
        }
    }
}
