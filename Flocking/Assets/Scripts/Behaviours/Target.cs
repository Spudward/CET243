using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/Target")]
public class Target : FlockBehaviour
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        GameObject target = GameObject.FindGameObjectWithTag("Player");

        Vector2 targetAngle = (target.transform.position - agent.transform.position).normalized;

        return targetAngle;
    }
}
