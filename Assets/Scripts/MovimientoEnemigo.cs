using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float velocidadMovimiento = 3f; // Velocidad de movimiento del enemigo
    public Transform puntoInicio; // Punto inicial de movimiento
    public Transform puntoFin; // Punto final de movimiento

    private bool moverHaciaFin = true;

    void Update()
    {
        // Mueve el enemigo entre los puntos de inicio y fin
        MoverEnemigo();
    }

    void MoverEnemigo()
    {
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
}
