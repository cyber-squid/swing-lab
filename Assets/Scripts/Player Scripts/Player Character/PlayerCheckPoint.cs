using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{

    public GrapplingHookL GrappleL;
    public GrapplingHookR GrappleR;
    ///private AIFollow aIFollow;
    ///public Transform levelposition;

    //public GameObject CheckPointMark;
    Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
     ///aIFollow = FindObjectOfType<AIFollow>();
        spawnPoint = gameObject.transform.position;
        GrappleL = GetComponentInChildren<GrapplingHookL>();
        GrappleR = GetComponentInChildren<GrapplingHookR>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = spawnPoint;
            GrappleL.StopGrapple();
            GrappleR.StopGrapple();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
         ///aIFollow.follow = false;
         ///aIFollow.goTolevelposition = true;
         ///aIFollow.targetposition = levelposition.position;
            spawnPoint = other.gameObject.transform.position;
            Destroy(other.gameObject);
        }
    }
}