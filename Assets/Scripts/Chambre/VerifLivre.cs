using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class VerifLivre : MonoBehaviour
{
    public EnigmeChambre enigme;

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
        if (other.CompareTag(gameObject.tag))
        {
            enigme.count++;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(gameObject.tag))
        {
            transform.position = other.transform.position;
            transform.rotation = other.transform.rotation;
        }
    }
}
