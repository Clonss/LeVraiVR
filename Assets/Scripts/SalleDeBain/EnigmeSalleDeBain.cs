using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeSalleDeBain : MonoBehaviour
{
    private GameObject oui1;
    private GameObject oui2;
    // Start is called before the first frame update
    void Start()
    {
        oui1 = null;
        oui2.name = "oui2";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(oui1.name != "Obj3")
        {
            oui1 = other.gameObject;
            Debug.Log(oui1.name);
        }
        /*else if(oui2.name != "Obj4")
        {
            oui2 = other.gameObject;
            Debug.Log(oui2.name);
        }*/
    }
}
