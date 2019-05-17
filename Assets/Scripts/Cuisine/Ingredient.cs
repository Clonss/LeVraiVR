using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<EnigmeCuisine>().nbrIngr++;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<EnigmeCuisine>().cooking)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<EnigmeCuisine>().nbrIngr--;
    }
}
