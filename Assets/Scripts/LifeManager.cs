using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public int maxLives = 3; // Número máximo de vidas
    private int currentLives; // Vidas actuales
    private Vector3 respawnPoint; // Punto de reaparición al perder una vida
    private CharacterController characterController;
    public GameManager gamemanager;
    public GameObject corazon1;
    public GameObject corazon2;
    public GameObject corazon3;


    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        currentLives = maxLives; // Inicializa las vidas al valor máximo
        respawnPoint = transform.position; // Guarda la posición inicial como punto de reaparición
    }

    private void Update()
    {
        // Verifica si el personaje ha caído por debajo del plano
        if (transform.position.y < -10f) // Puedes ajustar el valor de acuerdo a tu escena
        {
            LoseLife();
        }
    }

    private void LoseLife()
    {
        currentLives--;

        // Si aún quedan vidas, respawn en el punto de reaparición
        if (currentLives > 0)
        {
            Respawn();
            if (currentLives == 2){
                corazon3.SetActive(false);
            } else if (currentLives == 1){
                corazon2.SetActive(false);
            }

        }
        else
        {
            // Si se quedó sin vidas, reinicia el nivel o realiza alguna otra acción
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


    }

    private void Respawn()
    {
        // Repositiona al personaje en el punto de respawn
        characterController.enabled = false;
        transform.position = respawnPoint;
        characterController.enabled = true;
    }
}
