using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeCuisine : MonoBehaviour
{
    public int nbrIngr;

    public bool ready;

    // Start is called before the first frame update
    void Start()
    {
        nbrIngr = 0;
        ready = false;
    }

    // Update is called once per frame
    void Update()
    {
        Verify();
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
}
