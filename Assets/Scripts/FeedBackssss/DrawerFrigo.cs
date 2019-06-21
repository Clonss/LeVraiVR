using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerFrigo : MonoBehaviour
{
    public AudioSource DrawerOpening;
    public AudioSource DrawerClosing;
    private bool isPlayingSound = false;
    private float posInit;
    private float lastPos;

    // Start is called before the first frame update
    void Start()
    {
        posInit = transform.rotation.y;
        lastPos = posInit;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.y > lastPos && !isPlayingSound)
        {
            PlaySoundPull();
        }
        else if (transform.rotation.y < lastPos && !isPlayingSound)
        {
            PlaySoundPush();
        }
        else if (transform.rotation.y == lastPos && isPlayingSound)
        {
            StopSound();
        }

        lastPos = transform.rotation.y;
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
