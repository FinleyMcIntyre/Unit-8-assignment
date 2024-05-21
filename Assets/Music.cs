using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    public AudioClip backgroundmusic;
    private void Start()
    {
        musicSource.clip = backgroundmusic;
        musicSource.Play();
    }
}
