using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    Rigidbody myRB;
    public float moveSpeed, jumpForce;
    protected void Start()
    {
        myRB = gameObject.GetComponent<Rigidbody>();
    }
    protected virtual void Move(int xInput, int YInput)
    {
        myRB.velocity = new Vector3(xInput * moveSpeed * Time.deltaTime, myRB.velocity.y, 0);
        if (YInput > 0)
        {
            myRB.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    } 
}
