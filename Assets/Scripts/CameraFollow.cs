using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objeto que la cámara seguirá

    public float smoothSpeed = 0.125f; // Velocidad de suavizado de movimiento de la cámara
    public Vector3 offset; // La posición relativa de la cámara respecto al objetivo

    void LateUpdate()
    {
        if (target != null)
        {
            // Calcula la posición deseada de la cámara sumando la posición del objetivo y el offset
            Vector3 desiredPosition = target.position + offset;

            // Interpola suavemente entre la posición actual de la cámara y la posición deseada
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Establece la posición de la cámara
            transform.position = smoothedPosition;

            // Mira hacia el objetivo
            transform.LookAt(target);
        }
    }
}

