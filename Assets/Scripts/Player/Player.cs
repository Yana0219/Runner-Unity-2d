using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 50;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Health: " + health);
        if (health < 1)
        {
            Die();
        }
            
    }

    public void Die()
    {
        Debug.Log("Dead!");
        Time.timeScale = 0;
        //Destroy(this.gameObject);
    }
}
