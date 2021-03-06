﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    public AudioSource DrawerOpening;
    public AudioSource DrawerClosing;
    private bool isPlayingSound = false;
    private float posInit;
    private float lastPos;
    
    // Start is called before the first frame update
    void Start()
    {
        posInit = transform.rotation.x;
        lastPos = posInit;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.rotation.x > lastPos && !isPlayingSound)
        {
            PlaySoundPull();
        }
        else if(transform.rotation.x < lastPos && !isPlayingSound)
        {
            PlaySoundPush();
        }
        else if(transform.rotation.x == lastPos && isPlayingSound)
        {
            StopSound();
        }

        lastPos = transform.rotation.x;
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
