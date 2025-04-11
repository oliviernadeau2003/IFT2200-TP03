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
            gameObject.SetActive(false);
        }
    }
}
