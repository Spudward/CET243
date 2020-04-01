using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    public InputField myInput;
    public Rigidbody myRb;

    void Start()
    {
        myInput.Select();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (myInput.text == "Forward" || myInput.text == "forward")
            {
                myRb.AddForce(transform.forward * 500);
            }
            if (myInput.text == "Left" || myInput.text == "left")
            {
                myRb.AddForce(-transform.right * 500);
            }
            if (myInput.text == "Right" || myInput.text == "right")
            {
                myRb.AddForce(transform.right * 500);
            }
            if (myInput.text == "Back" || myInput.text == "back")
            {
                myRb.AddForce(-transform.forward * 500);
            }
            myInput.text = "";
            
        }
        myInput.Select();

    }
}
