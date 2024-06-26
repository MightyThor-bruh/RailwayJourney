using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip clicksound;
    public AudioSource sound;

    public void ClickSound()
    {
        sound.PlayOneShot(clicksound);
    }
}
