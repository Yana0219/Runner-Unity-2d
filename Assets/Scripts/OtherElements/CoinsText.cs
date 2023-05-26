using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsText : MonoBehaviour
{

    public static int Coin;
    Text text;
    
    void Start()
    {
          text = GetComponent<Text>();  
    }

    void Update()
    {
        text.text ="Coins: "+Coin.ToString();
    }
}
