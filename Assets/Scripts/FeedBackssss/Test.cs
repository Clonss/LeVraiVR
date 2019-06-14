using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public ParticleSystem fallVFX;
    bool onGround = true;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (onGround)
        {
            fallVFX.transform.position = transform.position;
            fallVFX.Play();
        }
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }
}
