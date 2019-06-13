using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeIt : MonoBehaviour
{
    private Rigidbody rB;
    public AudioSource pouf;
    public bool grabbed = false;
    private bool clipEnded = false;

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
        if(pouf.time == pouf.clip.length)
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
        pouf.Play();
        grabbed = true;
    }

    void SoundEnded()
    {
        grabbed = false;
    }
}
