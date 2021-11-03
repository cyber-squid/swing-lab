using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{

    //  public GameObject CheckPointMark;
    public Transform levelposition;
    Vector3 spawnPoint;

    private AIFollow aIFollow;
    // Start is called before the first frame update
    void Start()
    {
        aIFollow = FindObjectOfType<AIFollow>();
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            aIFollow.follow = false;
            aIFollow.goTolevelposition = true;
            aIFollow.targetposition = levelposition.position;
            spawnPoint = other.gameObject.transform.position;
            Destroy(other.gameObject);
        }
    }
}