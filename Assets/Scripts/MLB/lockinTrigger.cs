using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class lockinTrigger : MonoBehaviour
{
    public Transform lockForm;
    // Start is called before the first frame update
    void Start()
    {
        lockForm = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        lockForm = GetComponent<Transform>();
        if (other.CompareTag("triggerObject"))
        {
            lockForm.eulerAngles = new Vector3(0, 0, 0);
            gameObject.GetComponent<Rigidbody>().freezeRotation = true;
        }
    }
}
