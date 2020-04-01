using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/SteeredCohesion")]
public class SteeredCohesion : FlockBehaviour
{

    Vector2 curVelocity;
    public float agentSmooth = 0.5f;

    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        if (context.Count == 0)
        {
            return Vector2.zero;
        }

        Vector2 cohesionMove = Vector2.zero;
        foreach (Transform item in context)
        {
            if (!item.CompareTag("Walls") && !item.CompareTag("Player"))
            {
                cohesionMove += (Vector2)item.position;
            }
        }
        cohesionMove /= context.Count;

        cohesionMove -= (Vector2)agent.transform.position;
        cohesionMove = Vector2.SmoothDamp(agent.transform.up, cohesionMove, ref curVelocity, agentSmooth);
        return cohesionMove;
    }

}
