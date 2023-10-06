using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool activado = false;
    [SerializeField] GameObject playui;
    [SerializeField] GameObject ingameui;
    [SerializeField] TMP_Text contador;
    [SerializeField] GameObject pauseui;

    void Start()
    {
        ingameui.SetActive(false);
        pauseui.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        int contador = 0;

        while(true)
        {
            //Debug.Log(contador);
            contador++;
            this.contador.text = "" + contador;
            yield return new WaitForSeconds(1f);
        }
    }

    public void pausarui(){
        ingameui.SetActive(false);
        playui.SetActive(false);
        pauseui.SetActive(true);
        GameManager.activado = true;
    }
}

