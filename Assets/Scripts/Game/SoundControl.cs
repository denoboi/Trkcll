using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    [SerializeField]
    AudioClip asteroidDestroySound = default;

    [SerializeField]
    AudioClip shipDestroySound = default;

    [SerializeField]
    AudioClip shipDestroySound2 = default;

    [SerializeField]
    AudioClip bulletSound = default;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   
    public void AsteroidDestroySound()
    {
        audioSource.PlayOneShot(asteroidDestroySound, 0.8f);
    }

    public void ShipDestroySound()
    {
        audioSource.PlayOneShot(shipDestroySound, 0.5f);
        audioSource.PlayOneShot(shipDestroySound2, 0.3f);
    }

    public void FireSound()
    {
        audioSource.PlayOneShot(bulletSound, 0.1f);
    }
}
