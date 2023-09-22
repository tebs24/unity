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
    void Start()
    {
        ingameui.SetActive(false);
        
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

    private IEnumerator Contar ()
    {
        int contador = 0;

        while(true)
        {
            Debug.Log(contador);
            contador++;
            this.contador.text = "" + contador;
            yield return new WaitForSeconds(1f);
        }
    }
}

