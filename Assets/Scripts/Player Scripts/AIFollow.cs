using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour
{
    public GameObject Player;
    public float TargetDistance;
    public float AllowedDistance;
    public GameObject PetAI;
    public float followSpeed;
    public RaycastHit shot;


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            TargetDistance = shot.distance;
            if (TargetDistance >= AllowedDistance)
            {
                followSpeed = 0.5f;
                //PetAI.GetComponent<Animation>().Play("flying");
                transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, followSpeed);
            }
            else
            {
                followSpeed = 0;
                //PetAI.GetComponent<Animation>().Play("idle");
            }
        }
        
    }
}
