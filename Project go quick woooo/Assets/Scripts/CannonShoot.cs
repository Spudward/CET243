using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{

    public float minTime, maxTime;
    void Start()
    {
        StartCoroutine("SpawnBall");
    }

    IEnumerator SpawnBall ()
    {
        float myTime = Random.Range(minTime, maxTime);
        yield return new WaitForSeconds(myTime);
        GameObject myBall = cannonBallPool.pool.PullObject();
        myBall.transform.position = transform.position;
        myBall.transform.rotation = transform.rotation;
        ScoreHolder.score.myScore++;
        StartCoroutine("SpawnBall");
    }
}
