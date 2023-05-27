using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private Rigidbody2D rb;
    
    [SerializeField] private float speed;

    [SerializeField] private float jumpForce;

    private bool onGround;
    [SerializeField] Transform groundChecker;
    [SerializeField] float groundCkeckerRadius;
    [SerializeField]  private LayerMask groundLayer;
    private float originGravityScale;
    [SerializeField] private float fallGravityScale;

    private bool isGround;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originGravityScale = rb.gravityScale;
    }


    public void Move(float moveX)
    {
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
        
    }

    public void Jump()
    {
        if(CheckingGround())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void OnDrawGizmos()
    {
        if (groundChecker)
        {
            Gizmos.DrawWireSphere(groundChecker.position, groundCkeckerRadius);
        }
    }
    private void Update()
    {
        SetGravityScale();
    }
    private void SetGravityScale()
    {
        if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallGravityScale;
        }
        else
        {
            rb.gravityScale = originGravityScale;
        }
    }
    bool CheckingGround()
    {
        return Physics2D.OverlapCircle(groundChecker.position, groundCkeckerRadius, groundLayer);
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.collider.TryGetComponent(out Player player))
    //    {
    //        player.TakeDamage(damage);
    //    }
    //}
}
