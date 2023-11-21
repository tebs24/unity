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
    public UIManager ui;
    

    void Start()
    {
        ingameui.SetActive(false);
        pauseui.SetActive(false);
    }

    void Update(){    }
                            
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
            // Desactiva la moneda (puedes destruirla si no necesitas que vuelva a aparecer)
            gameObject.SetActive(false);
            ui.IncreaseCoins();
            ui.IncreaseScore(200);

            // Puedes agregar aquí lógica adicional, como reproducir un sonido o destruir el objeto chocado
            audioSource.Play(); 
        }
    }

    public void pausarui(){
        ingameui.SetActive(false);
        playui.SetActive(false);
        pauseui.SetActive(true);
        GameManager.activado = true;
    }
}

