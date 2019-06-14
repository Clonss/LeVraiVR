using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeIt : MonoBehaviour
{
    private Rigidbody rB;
    public AudioSource grabSound;
    public bool grabbed = false;
    private bool clipEnded = false;

    public ParticleSystem fallVFX;
    bool onGround = true;

    public AudioSource fallSound;
    private bool feltOnGround = false;
    private bool clip2Ended = false;

    public void Start()
    {
        rB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (onGround)
        {
            fallVFX.transform.position = transform.position;
            fallVFX.Play();
        }
    }

    public void Update()
    {
        if (rB.isKinematic && !grabbed)
        {
            Grab();
        }

        if(grabSound.time == grabSound.clip.length)
        {
            clipEnded = true;
            if (!rB.isKinematic)
            {
                SoundEnded();
            }
        }

        if (!rB.isKinematic && clipEnded)
        {
            clipEnded = false;
            SoundEnded();
        }

        if (feltOnGround)
        {
            Felt();
        }
    }

    void Grab()
    {
        grabSound.transform.position = transform.position;
        grabSound.Play();
        grabbed = true;
    }

    void SoundEnded()
    {
        grabbed = false;
    }

    void Felt()
    {
        fallSound.transform.position = transform.position;
        fallSound.Play();
        feltOnGround = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = false;
            feltOnGround = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = true;
            feltOnGround = true;
        }
    }
}
