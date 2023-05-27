using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    void Notify();
}

public class GameManager : MonoBehaviour, IObserver
{

    void Start()
    {
        Player.Instance.AddObserver(this);
    }

    void Update()
    {
    }

    public void Notify()
    {
        Score.Instance.Update();
    }
}

