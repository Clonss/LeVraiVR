﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tableaux : MonoBehaviour
{
    public static GameObject aunt;
    public static GameObject dad;
    public static GameObject mom;
    public static GameObject grandma;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        dad = GameObject.Find("PortaitCanvas001");
        mom = GameObject.Find("PortaitCanvas002");
        grandma = GameObject.Find("PortaitCanvas003");
        aunt = GameObject.Find("PortaitCanvas004");
    }

    // Update is called once per frame
    void Update()
    {
        TableauxCheck();
    }

    void TableauxCheck()
    {
        if (gameManager.unlockedAunt)
        {
            aunt.SetActive(true);
        }
        else
        {
            aunt.SetActive(false);
        }

        if (gameManager.unlockedDad)
        {
            dad.SetActive(true);
        }
        else
        {
            dad.SetActive(false);
        }

        if (gameManager.unlockedMom)
        {
            mom.SetActive(true);
        }
        else
        {
            mom.SetActive(false);
        }

        if (gameManager.unlockedGrandma)
        {
            grandma.SetActive(true);
        }
        else
        {
            grandma.SetActive(false);
        }
    }
}
