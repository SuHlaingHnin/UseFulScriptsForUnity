using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut_2 : MonoBehaviour
{
    Image image;
    Color c;

    private void Start()
    {
        image = GetComponent<Image>();
        c = image.color;
        c.a = 0f;
        image.color = c;

        StartCoroutine("FadeIn");
    }

    IEnumerator FadeIn()
    {
        for (float f = 0.01f; f <= 1f; f += 0.01f)
        {
            c.a = f;
            image.color = c;
            yield return new WaitForSeconds(0.01f);
        }
        
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeOut()
    {
        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            c.a = f;
            image.color = c;
            yield return new WaitForSeconds(0.1f);
        }
        StartCoroutine("FadeIn");
    }
}