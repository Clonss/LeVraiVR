using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class lockinTrigger : MonoBehaviour
{
    public GameObject triggerObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("triggerObject"))
        {
            transform.Rotate(1, 2, 3);
        }
    }
}
