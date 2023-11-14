using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarTexturaBloque : MonoBehaviour
{
    public Material nuevoMaterial; // Material con la nueva textura

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que chocó es el jugador
        if (other.CompareTag("Player"))
        {
            // Cambia la textura del bloque al material especificado
            CambiarTextura();
        }
    }

    void CambiarTextura()
    {
        // Verifica si se ha asignado un nuevo material
        if (nuevoMaterial != null)
        {
            // Obtén el Renderer del objeto (asegúrate de que el objeto tiene un Renderer)
            Renderer rendererBloque = GetComponent<Renderer>();

            // Asigna el nuevo material al Renderer
            rendererBloque.material = nuevoMaterial;
        }
    }
}
