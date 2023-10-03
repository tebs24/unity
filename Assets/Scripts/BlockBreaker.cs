using UnityEngine;

public class BlockBreaker : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el personaje está colisionando con un bloque desde arriba
        if (collision.relativeVelocity.y <= 0)
        {
            // Comprueba si el objeto con el que colisionamos tiene un tag "Bloque"
            if (collision.gameObject.CompareTag("Bloque"))
            {
                // Destruye el bloque
                Destroy(collision.gameObject);
            }
        }
    }
}
