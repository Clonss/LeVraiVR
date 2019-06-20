using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    public AudioSource DrawerOpening;
    public AudioSource DrawerClosing;
    private bool isOpened = false;
    private bool isClosed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged)
        {
            if(isOpened && !isClosed)
            {
                isOpening();
            }

            if(!isOpened && isClosed)
            {
                isClosing();
            }
        }
    }

    void isOpening()
    {
        isOpened = true;
        isClosed = false;
        DrawerOpening.transform.position = transform.position;
        DrawerOpening.Play();
    }

    void isClosing()
    {
        isOpened = false;
        isClosed = true;
        DrawerClosing.transform.position = transform.position;
        DrawerClosing.Play();
    }
}
