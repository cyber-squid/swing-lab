using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{
    private AIFollow aIFollow;
    public Transform levelposition;
    public bool followPlayer;
    Vector3 spawnPoint;
    private PlayerMovementController pmc;
    public AudioSource CheckpointSound;

    // Start is called before the first frame update
    void Start()
    {
        pmc = FindObjectOfType<PlayerMovementController>();
        aIFollow = FindObjectOfType<AIFollow>();
        spawnPoint = gameObject.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pmc.spawnPoint = spawnPoint;
            CheckpointSound.Play();
            Destroy(this.gameObject);
            if (followPlayer)
            {
                aIFollow.follow = true;
                aIFollow.goTolevelposition = false;
            }
            else
            {
                aIFollow.follow = false;
                aIFollow.goTolevelposition = true;
                aIFollow.targetposition = levelposition.position;
            }
        }
    }
}