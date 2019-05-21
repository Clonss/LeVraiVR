using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disque : MonoBehaviour
{
    public bool isTrue = false;
    public GameObject spot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isTrue == true)
        {
            spin();
        }
    }

    void spin()
    {
        transform.Rotate(0, 0.5f, 0 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Aiguille")
        {
            isTrue = true;
            spot.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isTrue = false;
        spot.SetActive(false);
    }
}
