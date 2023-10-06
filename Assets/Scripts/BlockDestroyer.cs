using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockDestroyer : MonoBehaviour
{
    public int pointsPerBlock = 60; // Puntos ganados por cada bloque destruido
    //public Text scoreText; // Texto en la interfaz de usuario para mostrar el puntaje

    //private int score = 0; // Puntaje actual

    private void Start()
    {
        // Inicializa el puntaje al comienzo del juego
      // UpdateScoreText();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Comprueba si el objeto con el que colisionamos tiene un tag "Bloque"
        if (hit.gameObject.CompareTag("Bloque"))
        {
            // Destruye el bloque
            Destroy(hit.gameObject);

            // Suma puntos al puntaje
            //score += pointsPerBlock;

            // Actualiza el puntaje en la interfaz de usuario
           // UpdateScoreText();
        }
    }

   /* private void UpdateScoreText()
    {
        // Actualiza el texto en la interfaz de usuario para mostrar el puntaje
        scoreText.text = "Puntaje: " + score.ToString();
    }*/
}
