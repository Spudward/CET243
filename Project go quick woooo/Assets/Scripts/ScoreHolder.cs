using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHolder : MonoBehaviour
{
    public static ScoreHolder score;
    public int myScore;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        if (score == this)
        {
            Destroy(this.gameObject);
        } else if (score != this)
        {
            score = this;
        }

    }

}
