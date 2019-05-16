using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeCuisine : MonoBehaviour
{
    public GameObject ingr1;
    public GameObject ingr2;
    public GameObject ingr3;

    public bool ready;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        /*if(other.gameObject == ingr1 && other.gameObject == ingr2 && other.gameObject == ingr3)
        {
            Debug.Log("oui");
        }*/

        Debug.Log(other);
    }
}
