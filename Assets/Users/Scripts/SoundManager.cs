using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;
    public static SoundManager Instance{get{return instance;}}

    [SerializeField] private AudioSource SoundEffects;
    [SerializeField] private AudioSource SoundMusic;
    [SerializeField] private bool Ismute=false;
    [SerializeField] private float volume=1f;
    [SerializeField] private SoundsType[] sounds;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    void Start()
    {
        // SetVolume(0.5f);
        PlayMusic(SoundManager.Sounds.Music);  
    }

    public void SetVolume(float volume)
    {
        SoundMusic.volume = volume;
    }

    public void Mute(bool status)
    {
        Ismute = status;
    }

    public void PlayMusic(Sounds sound)
    {
        if (Ismute)
        return;

        AudioClip clip = getSoundClip(sound);
        if(clip != null)
        {
            SoundMusic.clip = clip;
            SoundMusic.Play();
        }
        else{
            Debug.LogError("Clip Not Found for "+sound);
        }

    }

    public void Play(Sounds sound)
    {
        if (Ismute)
        return;
        AudioClip clip = getSoundClip(sound);
        if(clip != null)
        {
            SoundEffects.PlayOneShot(clip) ;
        }
        else{
            Debug.LogError("Clip Not Found for "+sound);
        }
    }

    private AudioClip getSoundClip(Sounds sound)
    {
        SoundsType item = Array.Find(sounds, i=>i.soundTypes==sound);
        if (item!=null)
            return item.soundClip;
        return null;

    }

    [Serializable] public class SoundsType
    {
        public Sounds soundTypes;
        public AudioClip soundClip;        
    }

    public enum Sounds
    {
        ButtonClick,
        PlayerMove,
        Music,
        PlayerDeath,
        EnemyDeath,

    }





}
