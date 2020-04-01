using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : BasePlayer
{
    protected override void Move(int xInput, int YInput)
    {
        base.Move(xInput, YInput);
    }

    void Update()
    {
        int x = 0;
        int y = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = 1;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            y = 1;
        }
        else
        {
            y = 0;
        }
        if (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            x = 0;
        }

        Move(x, y);
    }
}