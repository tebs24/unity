using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float velocidadMovimiento = 3f; // Velocidad de movimiento del enemigo
    public Transform puntoInicio; // Punto inicial de movimiento
    public Transform puntoFin; // Punto final de movimiento
    public LifeManager lifeManager;
    public float RaycastLength_P = 0.6f;
    private bool moverHaciaFin = true;
    [SerializeField] private AudioSource killEnemySound;

    void Update()
    {
        // Mueve el enemigo entre los puntos de inicio y fin
        MoverEnemigo();
    }

    void MoverEnemigo(){
        if (moverHaciaFin)
        {
            transform.Translate(Vector3.right * velocidadMovimiento * Time.deltaTime);

            // Si alcanza el punto final, cambia la dirección
            if (transform.position.x >= puntoFin.position.x)
            {
                moverHaciaFin = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * velocidadMovimiento * Time.deltaTime);

            // Si alcanza el punto inicial, cambia la dirección
            if (transform.position.x <= puntoInicio.position.x)
            {
                moverHaciaFin = true;
            }
        }
    }

    void PlayerCollisions(){
        if (RaycastHitObject(Vector3.right , RaycastLength_P, out RaycastHit hitSides) && hitSides.collider.CompareTag("Player")){
            lifeManager.LoseLife();
            Debug.Log("Kill Player");
        }
        if (RaycastHitObject(Vector3.left , RaycastLength_P, out hitSides) && hitSides.collider.CompareTag("Player")){
            lifeManager.LoseLife();
            Debug.Log("Kill Player");
        }         }

    bool RaycastHitObject(Vector3 direction, float length, out RaycastHit hit){
        return Physics.Raycast(transform.position, direction, out hit, length);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que chocó es un enemigo
        if (other.CompareTag("Player"))
        {
            // Si el jugador no está saltando, pierde una vida y reinicia el nivel
            if (!IsJumping())
            {
                PlayerCollisions();
            }
            // Si el jugador está saltando, destruye el enemigo
            else
            {
                Destroy(other.gameObject);
                killEnemySound.Play();
            }
        }
    }

    bool IsJumping()
    {
        // Verifica si el jugador está en el suelo o no
        return !GetComponent<CharacterController>().isGrounded;
    }
}
