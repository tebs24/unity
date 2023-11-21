using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI CoinsText;

    private int score = 0;
    private int Coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       UpdateUI(); 
    }

    void UpdateUI(){
        scoreText.text = score.ToString("");
        CoinsText.text = "x" + Coins.ToString("");
    }

    public void IncreaseCoins(){
        Coins++;
    }

    public void IncreaseScore(int points){
        score += points;
    }
}
