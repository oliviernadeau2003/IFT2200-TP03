using System.Collections;
using UnityEngine;

public class InvetoryScript : MonoBehaviour
{

    float debut;
    float fin;
    bool isMoving = false;
    bool isShowed = false;
    Vector3 objectPosition;
    void Start()
    {
        isMoving = false;
        isShowed = false;

        debut = -200;
        fin = 150;

        objectPosition = gameObject.GetComponent<RectTransform>().anchoredPosition;
        objectPosition.y = debut;
        gameObject.GetComponent<RectTransform>().anchoredPosition = objectPosition;
    }

    void Update()
    {
        // Lorsque la touche "I" est pressée on affiche l'inventaire
        if (Input.GetKeyDown(KeyCode.I) && !isMoving)
        {
            isMoving = true;
            if (!isShowed)
            {
                StartCoroutine(MoveTo(debut, fin, 0.5f));
                isShowed = true;
            }
            else
            {
                StartCoroutine(MoveTo(fin, debut, 0.5f));
                isShowed = false;
            }
        }
    }

    IEnumerator MoveTo(float start, float end, float time)
    {
        float t = 0;
        while (t < time)
        {
            t += Time.deltaTime;
            objectPosition.y = Mathf.Lerp(start, end, t / time);
            gameObject.GetComponent<RectTransform>().anchoredPosition = objectPosition;
            yield return null;
        }
        isMoving = false;
    }
}
