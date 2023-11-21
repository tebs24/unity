using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour
{
    public LifeManager lifeManager;

    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que chocó es un enemigo
        if (other.CompareTag("Enemigo"))
        {
            // Si el jugador no está saltando, pierde una vida y reinicia el nivel
            if (!IsJumping())
            {
                lifeManager.LoseLife();
            }
            // Si el jugador está saltando, destruye el enemigo
            else
            {
                Destroy(other.gameObject);
            }
        }
    }

    bool IsJumping()
    {
        // Verifica si el jugador está en el suelo o no
        return !GetComponent<CharacterController>().isGrounded;
    }
}
