using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigosControlador : MonoBehaviour
{
    public float velocidadMovimiento = 3f; // Velocidad de movimiento del enemigo
    public Transform puntoInicio; // Punto inicial de movimiento
    public Transform puntoFin; // Punto final de movimiento
    public LifeManager lifeManager;
    public float RaycastLength_P = 0.6f;
    private bool moverHaciaFin = true;
    [SerializeField] private AudioSource killEnemySound;
    public UIManager ui;

    private const string playerTag = "Player";

    void Update()
    {
        // Mueve el enemigo entre los puntos de inicio y fin
        MoverEnemigo();
        PlayerCollisions();
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
        if (RaycastHitObject(Vector3.right , RaycastLength_P, out RaycastHit hitSides) && hitSides.collider.CompareTag(playerTag)){
            lifeManager.LoseLife();
            Debug.Log("Kill Player");
        }
        if (RaycastHitObject(Vector3.left , RaycastLength_P, out hitSides) && hitSides.collider.CompareTag(playerTag)){
            lifeManager.LoseLife();
            Debug.Log("Kill Player");
        }
        if (RaycastHitObject(Vector3.up, RaycastLength_P, out RaycastHit hitUp) && hitUp.collider.CompareTag(playerTag)){
            Debug.Log("Kill Goomba");
            gameObject.SetActive(false);
            killEnemySound.Play();   
            ui.IncreaseScore(100);     }

    bool RaycastHitObject(Vector3 direction, float length, out RaycastHit hit){
        return Physics.Raycast(transform.position, direction, out hit, length);
        }
    }
}
