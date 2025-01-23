using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource Music;
    [SerializeField] AudioSource SFX;

    [SerializeField] AudioClip Background;
    public AudioClip BulletSound;

    // Start is called before the first frame update
    void Start()
    {
        Music.clip = Background;
        Music.Play();
    }

    public void PlaySFX(AudioClip Clip)
    {
        Music.PlayOneShot(Clip);
    }

    
}
