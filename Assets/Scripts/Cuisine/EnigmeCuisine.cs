using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeCuisine : MonoBehaviour
{
    public int nbrIngr;
    public bool check;
    public bool bake;

    public GameObject resultat;
    public GameObject VFX;

    private GameManager gameManager;

    private Transform cakeTransform;

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
            VFX.SetActive(true);
            bake = true;
            check = false;
            nbrIngr = 0;
            gameManager.ghostsNbr++;
        }
    }
}
