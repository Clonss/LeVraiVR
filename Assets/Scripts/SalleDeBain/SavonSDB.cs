using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavonSDB : MonoBehaviour
{
    private GameObject triggerFirstObject;
    private GameObject triggerSecondObject;
    public GameObject firstObject;
    public GameObject secondObject;

    // Start is called before the first frame update
    void Start()
    {
        triggerFirstObject = gameObject;
        triggerSecondObject = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerFirstObject.name != firstObject.name)
        {
            triggerFirstObject = other.gameObject;
            Debug.Log(triggerFirstObject.name);
        }

        if(secondObject != null)
        {
            if (triggerSecondObject.name != secondObject.name)
            {
                triggerSecondObject = other.gameObject;
                Debug.Log(triggerSecondObject.name);
            }
        }
        
    }
}
