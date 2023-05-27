using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected int damage = 1;
    [SerializeField] protected string dieAnimationName;
    [SerializeField] protected float dieDuration;
    protected Animator _animator;
    private void Start()
    {
        _animator= GetComponent<Animator>();
    }
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {
            player.TakeDamage(damage);
            _animator.SetTrigger(dieAnimationName);
            Invoke(nameof(DestroyEnemy), dieDuration);
        }
    }
    protected void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
