﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeCuisine : MonoBehaviour
{
    public int nbrIngr;
    public bool check;
    public bool bake;

    public GameObject resultat;
    public ParticleSystem VFX;
    public AudioSource SuccessSound;

    private GameManager gameManager;

    private Transform cakeTransform;

    public ParticleSystem granMa;
    public GameObject pathGranMa;

    // Start is called before the first frame update
    void Start()
    {
        nbrIngr = 0;
        bake = false;
        check = false;
        SetCakeTransform();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIngr();
    }

    void SetCakeTransform()
    {
        cakeTransform = gameObject.transform;
        Debug.Log(cakeTransform.position);
    }

     void CheckIngr()
    {
        if(nbrIngr == 3)
        {
            check = true;
        }
        else
        {
            check = false;
        }
    }

    public void CheckFinal()
    {
        if (check)
        {
            Instantiate(resultat, cakeTransform);
            bake = true;
            check = false;
            nbrIngr = 0;
            gameManager.ghostsNbr++;
            gameManager.unlockedGrandma = true;
            VFX.transform.position = transform.position;
            VFX.Play();
            SuccessSound.transform.position = transform.position;
            SuccessSound.Play();
            granMa.transform.position = transform.position;
            pathGranMa.SetActive(true);
        }
    }
}
