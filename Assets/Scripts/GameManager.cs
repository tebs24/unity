using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool activado = false;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] GameObject playui;
    [SerializeField] GameObject ingameui;
    [SerializeField] GameObject pauseui;
    [SerializeField] TMP_Text contadort;
    [SerializeField] TMP_Text TextoContadorM;
    private int contadorm = 0;
    

    void Start()
    {
        ingameui.SetActive(false);
        pauseui.SetActive(false);
        ActualizarContador();
    }
                            
    public void activarui(){
        ingameui.SetActive(true);
        playui.SetActive(false);
        GameManager.activado = true;
        StartCoroutine(Contar());
    }

    public void desactivarui(){
        ingameui.SetActive(false);
        pauseui.SetActive(false);
        playui.SetActive(true);
        GameManager.activado = false;
    }

    private IEnumerator Contar ()
    {
        int contadort = 0;

        while(true)
        {
            //Debug.Log(contador);
            contadort++;
            this.contadort.text = "" + contadort;
            yield return new WaitForSeconds(1f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que chocó es el jugador
        if (other.CompareTag("Player"))
        {
            // Incrementa el contador y actualiza el texto del contador
            contadorm++;
            ActualizarContador();

            // Desactiva la moneda (puedes destruirla si no necesitas que vuelva a aparecer)
            gameObject.SetActive(false);

            // Puedes agregar aquí lógica adicional, como reproducir un sonido o destruir el objeto chocado
            audioSource.Play(); 
        }
    }

    void ActualizarContador()
    {
        // Actualiza el texto del contador en el canvas
        if (TextoContadorM != null)
        {
            TextoContadorM.text = " " + contadorm.ToString();
        }
    }

    public void pausarui(){
        ingameui.SetActive(false);
        playui.SetActive(false);
        pauseui.SetActive(true);
        GameManager.activado = true;
    }
}

