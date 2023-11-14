using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMonedas : MonoBehaviour
{
    //public int valorMoneda = 10; // Puntos que se suman al recoger una moneda
    public AudioClip sonidoRecoger; // Sonido al recoger una moneda

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que chocó es el jugador
        if (other.CompareTag("Player"))
        {
            // Suma los puntos y reproduce el sonido
            RecogerMoneda();

            // Desactiva la moneda (puedes destruirla si no necesitas que vuelva a aparecer)
            gameObject.SetActive(false);
        }
    }

    void RecogerMoneda()
    {
        // Suma puntos al contador (puedes almacenar este valor donde lo necesites)
        //ContadorPuntos.SumarPuntos(valorMoneda);

        // Reproduce el sonido de recoger moneda
        if (sonidoRecoger != null)
        {
            AudioSource.PlayClipAtPoint(sonidoRecoger, transform.position);
        }
    }
}
