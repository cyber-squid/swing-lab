using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    public float Radius = 1f;
    public float TurnPerc = 1.0f;
    public float MaxRadius = 5f;
    public float Mass = 100;
    public float MaxSpeed = 3;
    public float MaxForce = 15;

    private Vector3 velocity;
    private Vector3 wanderForce;
    public Vector3 target;
    public float circleDistance = 5f;
    private Vector2 random;
    void Start()
    {
        random = Random.insideUnitCircle;
        StartCoroutine(GetNewDirection());
    }

    void Update()
    {
      //  Vector3 desiredVelocity = GetWanderForce();
      //  desiredVelocity = desiredVelocity.normalized * MaxSpeed;

      //  Vector3 steeringForce = desiredVelocity - velocity;
      //  steeringForce = Vector3.ClampMagnitude(steeringForce, MaxForce);
       // steeringForce /= Mass;

       // velocity = Vector3.ClampMagnitude(velocity + steeringForce, MaxSpeed);
        transform.position += velocity * Time.deltaTime;
        transform.forward = velocity.normalized;

        //Debug.DrawRay(transform.position, velocity.normalized * 2, Color.black);
        //Debug.DrawRay(transform.position, desiredVelocity.normalized * 2, Color.red);
    }


    private Vector3 GetWanderForce()
    {
        Vector3 circleCenter = velocity.normalized * circleDistance;
        Debug.DrawRay(transform.position, circleCenter, Color.red);
        Vector3 randomPoint = Random.insideUnitCircle;

        Vector3 displacement = new Vector3(randomPoint.x, randomPoint.y, randomPoint.z) * Radius;
        displacement = Quaternion.LookRotation(velocity) * displacement;

        Vector3 wanderForce = circleCenter + displacement;
        return wanderForce;
    }
    IEnumerator GetNewDirection()
    {
        velocity = new Vector3 (random.x, 0, random.y);
        wanderForce = GetWanderForce();
        velocity = wanderForce;
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(GetNewDirection());
    }
}

