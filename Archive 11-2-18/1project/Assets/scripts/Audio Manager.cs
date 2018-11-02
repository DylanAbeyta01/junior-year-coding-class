﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Object = UnityEngine.Object;
using System;


// Use this for initialization
public enum SoundEffect
{
    jump,
}
public class AudioManager
{
    static AudioManager instance;
    private Dictionary<SoundEffect, AudioClip> SoundEffects { get; set; }

    private AudioSource SoundEffectSource { get; set; }

    private AudioSource BGMSource { get; set; }

    public static AudioManager Instance
    { get { return instance ?? (instance = new AudioManager()); } }

    private AudioManager()
    {
        SoundEffects = Resources.LoadAll<AudioClip>("")
            .ToDictionary(t => (SoundEffect)Enum.Parse(typeof(SoundEffect), t.name, true));
        SoundEffectSource = new GameObject("SoundEffectSource", typeof(AudioSource)).GetComponent<AudioSource>();
        Object.DontDestroyOnLoad(SoundEffectSource.gameObject);

        BGMSource = new GameObject("BGMSource", typeof(AudioSource)).GetComponent<AudioSource>();
        BGMSource.volume = .5f;
        BGMSource.loop = true;
        Object.DontDestroyOnLoad(BGMSource.gameObject);
    }

    public void PlayOneShot(SoundEffect sound, float volumeScale = 1)
    {
        SoundEffectSource.PlayOneShot(SoundEffects[sound], volumeScale * 1);
    }
    public void ChangeBGm(AudioClip clip)
    {
        BGMSource.clip = clip;
        BGMSource.Play();
    }
}
// Update is called once per frame


