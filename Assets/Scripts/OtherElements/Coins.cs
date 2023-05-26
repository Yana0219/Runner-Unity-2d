using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    void Start()
    {
        
    }

    void Update()
    {
         transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            CoinsText.Coin +=1;
            Destroy(gameObject);
        }
    }
}
