using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/Alignment")]
public class Alignment : FlockBehaviour
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        if (context.Count == 0)
        {
            return agent.transform.up;
        }

        Vector2 alignmentMove = Vector2.zero;
        foreach (Transform item in context)
        {
            if (!item.CompareTag("Walls") && !item.CompareTag("Player"))
            {
                alignmentMove += (Vector2)item.transform.up;
            }
        }
        alignmentMove /= context.Count;

        return alignmentMove;
    }
}

