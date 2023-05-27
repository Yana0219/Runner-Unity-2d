using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 5;
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
        Restart();
        //Time.timeScale = 0;
        //Destroy(this.gameObject);
    }

    void Restart()
    {
        health = 5;
        SceneManager.LoadScene(0);
    }
}
