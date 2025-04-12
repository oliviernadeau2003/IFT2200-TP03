using UnityEngine;

public enum Items { Wood_stack, Bird_nest, Pickaxe, Phraon_mask,Golden_globe }
public class InventoryControllerScript : MonoBehaviour
{

    static bool[] collection = { false, false, false, false, false };
    static GameObject[] items = new GameObject[5];

    private void Awake()
    {
        for (int i = 0; i < items.Length; i++)
        {
            string nom = "Image" + (i + 1);
            GameObject gameObject = GameObject.Find(nom);
            if (gameObject != null)
            {
                items[i] = gameObject;
                gameObject.SetActive(false);
            }
            else
            {
                Debug.LogError("GameObject with name " + nom + " not found.");
            }
        }
    }

    public static bool Present(Items item)
    {
        return collection[(int)item];
    }
    public static void Add(Items item)
    {
        if (!Present(item))
        {
            collection[(int)item] = true;
            items[(int)item].SetActive(true);
        }
    }

    public static void Remove(Items item)
    {
        if (Present(item))
        {
            collection[(int)item] = false;
            items[(int)item].SetActive(false);
        }
    }
}
