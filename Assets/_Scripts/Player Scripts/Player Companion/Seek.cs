using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    Vector3 velocity;
    public Transform player;
    public bool follow = true;
    public float Mass = 100;
    public float MaxVelocity = 10;
    public float MaxForce = 10;
    public Transform targetposition;

    void Start()
    {
        follow = true;
        velocity = Vector3.zero;
    }

    void Update()
    {
        if (follow)
        {
            Move(player.transform);
        }
        else
        {
            Move(targetposition);
        }
    }

    private void Move(Transform target)
    {
        Vector3 desiredVelocity = target.transform.position + new Vector3(0, 0.4f, -4) - transform.position;
        desiredVelocity = desiredVelocity.normalized * MaxVelocity;

        Vector3 steering = desiredVelocity - velocity;
        steering = Vector3.ClampMagnitude(steering, MaxForce);
        steering = steering / Mass;

        velocity = Vector3.ClampMagnitude(velocity + steering, MaxVelocity);
        transform.position += velocity * Time.deltaTime;
        //transform.forward = velocity.normalized;

        Debug.DrawRay(transform.position, velocity.normalized * 2, Color.black);
        Debug.DrawRay(transform.position, desiredVelocity.normalized * 2, Color.red);
    }
}

