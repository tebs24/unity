using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip musicaJuego; // Archivo de audio para la música del juego
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Puedes reproducir la música aquí directamente o hacerlo en respuesta a algún evento, como el botón "Play"
    }

    public void PlayMusic()
    {
        // Asigna el clip de audio y reproduce la música
        audioSource.clip = musicaJuego;
        audioSource.loop = true; // Reproduce la música en bucle
        audioSource.Play();
    }
}

