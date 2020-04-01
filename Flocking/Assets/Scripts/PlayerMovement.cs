using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 5f;

    Vector2 move;
    Rigidbody2D myRb;

    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float xInput;
        float yInput;
        if (Input.GetKey(KeyCode.W))
        {
            yInput = 1;
        } else if (Input.GetKey(KeyCode.S))
        {
            yInput = -1;
        } else
        {
            yInput = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            xInput = 1;
        } else if (Input.GetKey(KeyCode.A))
        {
            xInput = -1;
        } else
        {
            xInput = 0;
        }

        Vector2 temp = new Vector2(xInput, yInput);
        move = temp * maxSpeed;

        Move(move);
       
    }

    void Move(Vector2 velocity)
    {
        
        if (velocity == Vector2.zero)
        {
            myRb.velocity = Vector2.zero;
        }
        else
        {
            myRb.velocity = velocity;
            transform.up = velocity;
        }
    }
}
