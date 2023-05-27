using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMouse : Enemy
{
    [SerializeField] private float speed = 1f;
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
