using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : BasePlayer
{
    protected override void Move(int xInput, int YInput)
    {
        base.Move(xInput, YInput);
    }

    void Update()
    {
        int x = 0;
        int y = 0;
        if (Input.GetKey(KeyCode.A))
        {
            x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = 1;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            y = 1;
        } else
        {
            y = 0;
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            x = 0;
        }

        Move(x, y);
    }
}
