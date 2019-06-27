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

    public AudioSource fallSound;
    private bool clip2Ended = false;

    public void Start()
    {
        rB = GetComponent<Rigidbody>();
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

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground") || collision.collider.CompareTag("Surface"))
        {
            fallSound.transform.position = transform.position;
            fallSound.Play();
            fallVFX.transform.position = transform.position;
            fallVFX.Play();
            /*GameObject tmpGo = Instantiate(fallVFX, collision.GetContact(0).point, Quaternion.identity);
            Destroy(tmpGo, 1f);*/
        }
    }
}
