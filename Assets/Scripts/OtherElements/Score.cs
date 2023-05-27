using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; } 
    public float scoreValue = 0; 
    private Text score; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        score = GetComponent<Text>();
    }

    public void Update()
    {
        score.text ="Score: "+scoreValue;
    }

}
