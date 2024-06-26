using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSoundScript : MonoBehaviour
{
    public AudioClip impact;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

}
