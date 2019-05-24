using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeCuisine : MonoBehaviour
{
    public int nbrIngr;

    public GameObject resultat;
    public GameObject VFX;
    private GameManager gameManager;

    public bool ready;
    public bool validate;
    public bool cooking;

    // Start is called before the first frame update
    void Start()
    {
        nbrIngr = 0;
        ready = false;
        validate = false;
        cooking = false;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Verify();
        Rewarded();
    }

    void Verify()
    {
        if(nbrIngr == 3)
        {
            ready = true;
        }
        else
        {
            ready = false;
        }
    }

    public void Validate()
    {
        if (ready)
        {
            validate = true;
        }
        else
        {
            validate = false;
        }
    }

    void Rewarded()
    {
        if(validate == true)
        {
            Instantiate(resultat,gameObject.transform);
            VFX.SetActive(true);
            nbrIngr = 0;
            cooking = true;
            validate = false;
            gameManager.ghostsNbr++;
        }
    }
}
