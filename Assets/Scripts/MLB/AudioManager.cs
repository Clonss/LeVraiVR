﻿
using UnityEngine;
using System;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
    
    public void Play (string name)
    {

           Sound s = Array.Find(sounds, Sound => Sound.name == name);
           if (s == null)
           {
               Debug.LogWarning("Sound : " + name + "not found");
               return;
           }
           s.source.Play();

    }
}
