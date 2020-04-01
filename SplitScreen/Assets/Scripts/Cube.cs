using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cube : MonoBehaviour
{
    Player1Controls controls;

    public Rigidbody myRb;
    public float moveSpeed;
    public Transform Camera;

    Vector2 move;
    Vector2 rotate;
    private void Awake()
    {
        controls = new Player1Controls();

        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;

        controls.Gameplay.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        controls.Gameplay.Rotate.canceled += ctx => rotate = Vector2.zero;

    }

    private void Update()
    {
        Vector3 m = new Vector3 (move.x * Time.deltaTime * moveSpeed, myRb.velocity.y, move.y * Time.deltaTime * moveSpeed) ;
        myRb.velocity = m;

        Rotate();
    }
    Vector3 GetOffset(Vector3 offset)
    {
        float xOffset, yOffset, zOffset;

        if (transform.forward.x != 0)
        {
            xOffset = offset.x * (transform.forward.x * -1);
        }
        else
        {
            xOffset = offset.x;
        }
        if (transform.forward.y != 0)
        {
            yOffset = offset.y * (transform.forward.y * -1);
        }
        else
        {
            yOffset = offset.y;
        }
        if (transform.forward.z != 0)
        {
            zOffset = offset.z * (transform.forward.z * -1);
        }
        else
        {
            zOffset = offset.z;
        }
        return new Vector3(xOffset, yOffset, zOffset);
    }

    void Rotate ()
    {
        Vector3 cameraRotate, modelRotate;

        cameraRotate = new Vector3(-rotate.y, 0, 0) * 100f * Time.deltaTime;
        modelRotate = new Vector3(0, rotate.x, 0) * 100f * Time.deltaTime;
        //Camera.Rotate(cameraRotate, Space.Self);
        //Camera.Rotate(modelRotate, Space.World);
        transform.Rotate(modelRotate, Space.World);
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }
    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
