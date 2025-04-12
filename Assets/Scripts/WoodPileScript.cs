using TMPro;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class WoodPileScript : MonoBehaviour
{

    public GameObject particles;
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
            particles.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
