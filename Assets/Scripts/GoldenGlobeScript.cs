using UnityEngine;

public class GoldenGlobeScript : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        // V�rifie si le joueur a cliqu� sur l'objet
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
        }
    }
}
