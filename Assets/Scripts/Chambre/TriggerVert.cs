using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class TriggerVert : MonoBehaviour
{
    public GameObject trigger;

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
        if (other.CompareTag("Vert"))
        {
            transform.position = other.transform.position;
            transform.rotation = other.transform.rotation;
            trigger.GetComponent<BoxCollider>().enabled = false;
            Destroy(gameObject.GetComponent<Throwable>());
        }
    }
}
