using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/Avoidance")]
public class Avoidance : FlockBehaviour
{
    GameObject[] walls;
    bool hasAddedWalls = false;
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        if (context.Count == 0)
        {
            return Vector2.zero;
        }

        walls = GameObject.FindGameObjectsWithTag("Walls");

        Vector2 avoidanceMove = Vector2.zero;
        int nAvoid = 0;
        for (int i = 0; i < walls.Length; i++)
        {
           //context.Add(walls[i].transform);
        }


        foreach (Transform item in context)
        {
            if (Vector2.SqrMagnitude(item.position - agent.transform.position) < flock.SquareAvoidanceRadius)
            {
                if (!item.CompareTag("Player")) {
                    nAvoid++;
                    avoidanceMove += (Vector2)(agent.transform.position - item.position);
                }
            }

        }
        if (nAvoid > 0)
        {
            avoidanceMove /= nAvoid;
        }
        return avoidanceMove;
    }
}
