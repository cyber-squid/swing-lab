using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObstacleAvoidance : MonoBehaviour
{
    Vector3 velocity;
    public float MAX_SEE_AHEAD = 10f;
    private RaycastHit hit;
    private bool blocked = false;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
      //  velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

      //  var ahead = transform.position + velocity.normalized * MAX_SEE_AHEAD;
       // var ahead2 = transform.position + velocity.normalized * MAX_SEE_AHEAD * 0.5f;

       // var avoidance_force = ahead - obstacle_center;


    }

  /*  private void CheckForCollison()
    {
      //  RaycastHit[] hit = new RaycastHit[2];

        //hit[0] = 

    }*/
}
