using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airportSFX : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.time = 110f;
        audioSource.Play();
    }
}
