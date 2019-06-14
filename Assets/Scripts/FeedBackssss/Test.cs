using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public ParticleSystem fallVFX;
    bool onGround = false;
    bool fallOnGround = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" && fallOnGround && onGround)
        {
            fallVFX.Play();
            Destroy(fallVFX, 0.5f);
        }
    }
}
