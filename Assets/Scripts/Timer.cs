using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    
    public TextMeshProUGUI texto;
    private int contador = 0;

    void Start()
    {
       if(GameManager.GameState != "play") return;
       InvokeRepeating("actualizar",1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = contador.ToString();
        contador++;
    }
}
