using UnityEngine;

public class GoldenGlobeScript : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        // Vérifie si le joueur a cliqué sur l'objet
        if (Input.GetMouseButtonDown(0))
        {
            // Ajoute l'objet à l'inventaire
            InventoryControllerScript.Add(Items.Golden_globe);
            gameObject.SetActive(false);
        }
    }
}
