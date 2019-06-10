using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeCuisine : MonoBehaviour
{
    public int nbrIngr;
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
        SetCakeTransform();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetCakeTransform()
    {
        cakeTransform.position = gameObject.transform.position;
    }

    public void Check()
    {
        if(nbrIngr == 3)
        {
            Rewarded();
            nbrIngr = 0;
        }
    }

    void Rewarded()
    {
        Instantiate(resultat,cakeTransform);
        VFX.SetActive(true);
        gameManager.ghostsNbr++;
        bake = true;
    }
}
