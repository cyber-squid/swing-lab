using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour
{
    public GameObject Player;
    public float TargetDistance;
    public float AllowedDistance;
    public float toofar = 7;
    public bool follow = true;
    public bool goTolevelposition = false;
    private bool hasFollowed;
    public GameObject PetAI;
    public float followSpeed;
    public Vector3 targetposition;
    void Start()
    {
        follow = true;
    }
    void Update()
    {
        if (follow)
        {
            transform.LookAt(Player.transform);
            TargetDistance = Vector3.Distance(Player.transform.position, this.transform.position);
            if (TargetDistance < AllowedDistance)
            {
                Move(Player.transform.position);
                hasFollowed = true;
            }
            if (hasFollowed && TargetDistance > toofar)
            {
                transform.position = Player.transform.position + new Vector3(0, 0, 1);
            }
        }
        else if(goTolevelposition)
        {
            transform.position = targetposition;
        }
    }
    public void Move(Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target + new Vector3(0, 0.4f, -4), followSpeed * Time.deltaTime);
    }
}
