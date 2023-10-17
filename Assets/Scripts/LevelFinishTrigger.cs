using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFinishTrigger : MonoBehaviour
{
    public Canvas congratsCanvas;

    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el personaje ha colisionado con el trigger
        if (other.CompareTag("Player"))
        {
            // Activa el Canvas de "Congrats!"
            congratsCanvas.gameObject.SetActive(true);
        }
    }
}
