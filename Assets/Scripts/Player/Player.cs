using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

interface IObservable
{
    void AddObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}

public class Player : MonoBehaviour, IObservable
{
    public static Player Instance { get; private set; } 

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

    private int health = 5;
    public Image[] hearts;
    public Sprite fullHeart;
    public List<IObserver> observers = new List<IObserver>();

   
    void Start()
    {
        
    }

    void Update()
    {
        Score.Instance.scoreValue+=Time.deltaTime*1;
        this.NotifyObservers();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Destroy(hearts[health].gameObject);
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
    
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Notify();
        }
    }

}
