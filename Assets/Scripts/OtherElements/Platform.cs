using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
