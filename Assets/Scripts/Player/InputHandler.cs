using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    MoveController moveController;
    void Start()
    {
        moveController= GetComponent<MoveController>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            moveController.Jump();
        }
    }


    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        moveController.Move(moveX);
    }
}
