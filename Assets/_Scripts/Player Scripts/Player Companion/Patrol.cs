using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public List<Transform> waypoints;
    public float MaxVelocity;
    public float MaxForce;
    public float Mass;
    Vector3 velocity;
    int index = 0;

    private void Start()
    {
        velocity = Vector3.zero;
    }
    void Update()
    {
        float distance = Vector3.Distance(transform.position, waypoints[index].position);

        if (distance < 1)
        {
            StartCoroutine(WaitOnWaypoint());
        }
        else
        {
            Move(waypoints[index]);
        }
    }

    IEnumerator WaitOnWaypoint()
    {
        yield return new WaitForSeconds(2);
        index++;
        if (index > waypoints.Count - 1)
        {
            index = 0;
        }
        StopAllCoroutines();
    }

    public void Move(Transform target)
    {
        Vector3 desiredVelocity = (target.transform.position - transform.position).normalized;
        desiredVelocity = desiredVelocity.normalized * MaxVelocity;

        Vector3 steering = desiredVelocity - velocity;
        steering = Vector3.ClampMagnitude(steering, MaxForce);
        steering = steering / Mass;

        velocity = Vector3.ClampMagnitude(velocity + steering, MaxVelocity);
        transform.position += velocity * Time.deltaTime;
        transform.forward = velocity.normalized;

        Debug.DrawRay(transform.position, velocity.normalized * 2, Color.black);
        Debug.DrawRay(transform.position, desiredVelocity.normalized * 2, Color.red);

    }
}
