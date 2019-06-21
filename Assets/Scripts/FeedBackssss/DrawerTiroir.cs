using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerTiroir : MonoBehaviour
{
    public AudioSource DrawerOpening;
    public AudioSource DrawerClosing;
    private bool isPlayingSound = false;
    private float posInit;
    private float lastPos;

    // Start is called before the first frame update
    void Start()
    {
        posInit = transform.position.z;
        lastPos = posInit;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > lastPos && !isPlayingSound)
        {
            PlaySoundPull();
        }
        else if (transform.position.z < lastPos && !isPlayingSound)
        {
            PlaySoundPush();
        }
        else if (transform.position.z == lastPos && isPlayingSound)
        {
            StopSound();
        }

        lastPos = transform.position.z;
    }

    void PlaySoundPull()
    {
        DrawerOpening.Play();
        isPlayingSound = true;
    }

    void PlaySoundPush()
    {
        DrawerClosing.Play();
        isPlayingSound = true;
    }

    void StopSound()
    {
        isPlayingSound = false;
        DrawerClosing.Pause();
    }
}
