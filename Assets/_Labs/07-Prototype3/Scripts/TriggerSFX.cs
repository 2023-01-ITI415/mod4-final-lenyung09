using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource playSound;
    public GameObject fpsGuy;

    void OnTriggerEnter(Collider other)
    {
        playSound.Play();
        fpsGuy.GetComponent<AudioSource>().enabled = !fpsGuy.GetComponent<AudioSource>().enabled;
    }

    void OnTriggerExit(Collider other)
    {
        playSound.Pause();
        fpsGuy.GetComponent<AudioSource>().enabled = !fpsGuy.GetComponent<AudioSource>().enabled;
    }
}
