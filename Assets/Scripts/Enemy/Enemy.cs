using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected int damage = 1;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {
            player.TakeDamage(damage);
        }
    }
}
