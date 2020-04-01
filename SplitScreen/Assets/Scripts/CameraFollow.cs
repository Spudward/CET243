using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform myPlayer;
    public Vector3 Offset;
    public float CameraSpeed, rotateSpeed;


    private void Start()
    {
        myPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        myPlayer.gameObject.GetComponent<Cube>().Camera = this.transform;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, myPlayer.position + GetOffset(Offset), CameraSpeed);
        Vector3 target = new Vector3(transform.rotation.x, transform.rotation.y, 0);
        //transform.rotation = Quaternion.Euler(target);
    }

    Vector3 GetOffset (Vector3 offset)
    {
        float xOffset, yOffset, zOffset;

        if (myPlayer.forward.x != 0)
        {
            xOffset = offset.x * (myPlayer.forward.x * -1);
        } else
        {
            xOffset = offset.x;
        }
        if (myPlayer.forward.y != 0)
        {
            yOffset = offset.y * (myPlayer.forward.y * -1);
        }
        else
        {
            yOffset = offset.y;
        }
        if (myPlayer.forward.z != 0)
        {
            zOffset = offset.z * (myPlayer.forward.z * -1);
        }
        else
        {
            zOffset = offset.z;
        }
        return new Vector3(xOffset, yOffset, zOffset);
    }
}
