using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavonSDB : MonoBehaviour
{
    private GameObject triggerFirstObject;
    private GameObject triggerSecondObject;
    public GameObject firstObject;
    public GameObject secondObject;

    public EnigmeSalleDeBain sdbManager;

    public bool check;
    private bool validated;

    // Start is called before the first frame update
    void Start()
    {
        triggerFirstObject = gameObject;
        triggerSecondObject = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        CheckFinal();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerFirstObject != firstObject)
        {
            triggerFirstObject = other.gameObject;
        }

        if(secondObject != null)
        {
            if (triggerSecondObject != secondObject)
            {
                triggerSecondObject = other.gameObject;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(secondObject == null)
        {
            if(triggerFirstObject == firstObject)
            {
                check = true;
            }
            else
            {
                check = false;
            }
        }
        else if(triggerSecondObject == secondObject)
        {
            if(triggerFirstObject == firstObject)
            {
                check = true;
            }
            else
            {
                check = false;
            }
        }
        else
        {
            check = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (triggerFirstObject == firstObject && other.gameObject == triggerFirstObject)
        {
            triggerFirstObject = gameObject;
            if (validated)
            {
                sdbManager.count--;
                validated = false;
            }
            
        }

        if (secondObject != null)
        {
            if (triggerSecondObject == secondObject && other.gameObject == triggerSecondObject)
            {
                triggerSecondObject = gameObject;
                if (validated)
                {
                    sdbManager.count--;
                    validated = false;
                }
            }
        }
    }

    void CheckFinal()
    {
        if(check == true)
        {
            if (validated == false)
            {
                sdbManager.count++;
                validated = true;
            }
        }
    }
}
