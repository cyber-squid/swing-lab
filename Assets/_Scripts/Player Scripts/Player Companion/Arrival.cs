using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrival : MonoBehaviour
{
    public Transform player;
    //public Transform targetposition;
    public float maxRadius;
    public bool arriving = true;
    Vector3 velocity;
    public float maxForce;
    public float MaxVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (arriving)
        {
            Arrive(player.transform);
        }
    }
    void Arrive(Transform target)
    {
        Vector3 desiredVelocity = target.transform.position - transform.position;
        desiredVelocity.Normalize();

        //calculate the distance between the target and the agent's current location
        float distanceFromTarget = Vector3.Distance(target.position, transform.position);

        //if the agent is close to the target, reduce the desired velocity
        if (distanceFromTarget < maxRadius) desiredVelocity *= distanceFromTarget;

        //else move towards the target at max speed
        else desiredVelocity *= MaxVelocity;

        Vector3 steer = Vector3.ClampMagnitude(desiredVelocity - velocity, maxForce);
    }
}
