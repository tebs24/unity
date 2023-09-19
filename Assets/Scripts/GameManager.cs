using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool activado = false;
    public static string GameState = "none"; 
    [SerializeField] GameObject playui;
    [SerializeField] GameObject ingameui;
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
        GameManager.GameState = "play";
    }
}
