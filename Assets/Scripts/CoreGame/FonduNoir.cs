using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FonduNoir : MonoBehaviour
{
    private CanvasGroup blackImage;
    private GameManager gameManager;
    public bool fadeOut;
    public bool fadeIn;
    public float fadeMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        blackImage = gameObject.GetComponent<CanvasGroup>();
        //gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        fadeOut = true;
        fadeMultiplier = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Fading();
    }

    void Fading()
    {
        if (fadeOut)
        {
            FadeOut();
            if (blackImage.alpha == 0)
            {
                fadeOut = false;
            }
        }

        if (fadeIn)
        {
            FadeIn();
            if (blackImage.alpha == 1)
            {
                fadeIn = false;
            }
        }
    }

    void FadeOut()
    {
        if(blackImage.alpha >= 0)
        {
            blackImage.alpha -= Time.deltaTime / fadeMultiplier;
        }
    }

    void FadeIn()
    {
        if (blackImage.alpha <= 1)
        {
            blackImage.alpha += Time.deltaTime / fadeMultiplier;
        }
    }
}
