﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.position;
    }
}
