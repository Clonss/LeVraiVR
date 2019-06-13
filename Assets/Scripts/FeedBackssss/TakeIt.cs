using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeIt : MonoBehaviour
{
    private Rigidbody rB;
    public AudioSource grabSound;
    public ParticleSystem fallVFX;
    public bool grabbed = false;
    private bool clipEnded = false;

    public void Start()
    {
        rB = GetComponent<Rigidbody>();
        fallVFX = GetComponent<ParticleSystem>();
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
        grabSound.Play();
        grabbed = true;
    }

    void SoundEnded()
    {
        grabbed = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            fallVFX.Play();
            ParticleSystem.ShapeModule _editableShape = fallVFX.shape;
            _editableShape.position = new Vector3(1f, 2f, 3f);
        }
    }
}
