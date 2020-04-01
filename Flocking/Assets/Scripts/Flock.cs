using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock : MonoBehaviour
{
    public FlockAgent AgentPrefab;
    List<FlockAgent> agents = new List<FlockAgent>();
    public FlockBehaviour behaviour;

    public float minX, maxX, minY, maxY, setZ, gizmosRadius;
    int agentsCreated;
    public int maxAgents;

    [Range(0.1f, 10f)]
    public float timeBetweenFlock = 1f;
    const float AgentDensity = 0.08f;

    [Range(1f, 100f)]
    public float driveFactor = 10f;
    [Range(1f, 100f)]
    public float maxSpeed = 5f;
    [Range(1f, 10f)]
    public float neighbourRadius = 1.5f;
    [Range(0f, 1f)]
    public float avoidanceRadius = 0.5f;

    float squareMaxSpeed;
    float squareNeighbourRadius;
    float squareAvoidanceRadius;
    public float SquareAvoidanceRadius { get { return squareAvoidanceRadius; }  }

    void Start()
    {
        squareMaxSpeed = maxSpeed * maxSpeed;
        squareNeighbourRadius = neighbourRadius * neighbourRadius;
        squareAvoidanceRadius = squareNeighbourRadius * avoidanceRadius * avoidanceRadius;

        StartCoroutine("SpawnCreature");
    }

    IEnumerator SpawnCreature ()
    {
        if (agentsCreated >= maxAgents)
        {
            StopCoroutine(SpawnCreature());
        }
        Vector3 randomPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), setZ);
        FlockAgent myAgent = Instantiate(AgentPrefab, randomPos, Quaternion.identity, transform);
        agents.Add(myAgent);
        agentsCreated++;
        yield return new WaitForSeconds(timeBetweenFlock);
        StartCoroutine("SpawnCreature");
       
    }

    void Update()
    {
        foreach (FlockAgent agent in agents)
        {
            List<Transform> context = GetNearbyObjects(agent);
            agent.GetComponentInChildren<SpriteRenderer>().color = Color.Lerp(Color.white, Color.red, context.Count / 6f);

            Vector2 move = behaviour.CalculateMove(agent, context, this);
            move *= driveFactor;
            if (move.sqrMagnitude > squareMaxSpeed)
            {
                move = move.normalized * maxSpeed;
            }
            agent.Move(move);
        }
    }

    List <Transform> GetNearbyObjects (FlockAgent agent)
    {
        List<Transform> context = new List<Transform>();
        Collider2D[] contextColliders = Physics2D.OverlapCircleAll(agent.transform.position, neighbourRadius);

        foreach(Collider2D c in contextColliders)
        {
            if (c!= agent.AgentCollider)
            {
                context.Add(c.transform);
            }
        }
        return context;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Random.ColorHSV();
        Gizmos.DrawSphere(new Vector3(minX, minY, setZ), gizmosRadius);
        Gizmos.color = Random.ColorHSV();
        Gizmos.DrawSphere(new Vector3(minX, maxY, setZ), gizmosRadius);
        Gizmos.color = Random.ColorHSV();
        Gizmos.DrawSphere(new Vector3(maxX, minY, setZ), gizmosRadius);
        Gizmos.color = Random.ColorHSV();
        Gizmos.DrawSphere(new Vector3(maxX, maxY, setZ), gizmosRadius);
    }
}
