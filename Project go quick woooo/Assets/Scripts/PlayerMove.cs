using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour
{
    public Transform groundPlane;
    public float moveAmount, moveSpeed;
    public Text text;
    public static int Score;

    //this movement is scuffed, please just excuse how bad this is
    void Update()
    {
        text.text = "Score: " + ScoreHolder.score.myScore.ToString();
        float xFactor = 0, yFactor = 0;
        if (Input.GetKey(KeyCode.W))
        {
            yFactor = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            yFactor = -1;
        }
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            yFactor = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            xFactor = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            xFactor = 1;
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            xFactor = 0;
        }
        Vector3 inputVector = new Vector3(xFactor, 0, yFactor);

        transform.position = Vector3.MoveTowards(transform.position, groundPlane.position + inputVector * moveAmount, moveSpeed * Time.deltaTime);
    }
}
