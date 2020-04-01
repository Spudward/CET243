using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBallPool : MonoBehaviour
{
    public int ballsToSpawn;
    public GameObject ballPrefab;
    public static cannonBallPool pool;
    GameObject[] balls;
    int lastPulled;

    void Start()
    {
        pool = this;
        lastPulled = 0;
        balls = new GameObject[ballsToSpawn];
        for (int i = 0; i < ballsToSpawn; i++)
        {
            GameObject myObject = Instantiate(ballPrefab, transform.position, transform.rotation);
            balls[i] = myObject;
            myObject.SetActive(false);
        }
    }

    public GameObject PullObject ()
    {
        bool FoundBall = false;
        for (int i = 0; i < balls.Length; i++)
        {
            if (!balls[i].activeSelf && !FoundBall)
            {
                FoundBall = true;
                balls[i].SetActive(true);
                return balls[i];
            }
        }
        if (!FoundBall)
        {
            GameObject objToPull = balls[lastPulled];
            lastPulled++;
            objToPull.SetActive(true);
            return objToPull;
        } else
        {
            return null;
        }
    }
}
