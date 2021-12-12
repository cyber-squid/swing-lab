using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{
    private Seek aIFollow;
    public Transform levelposition;
    public bool followPlayer;
    Vector3 spawnPoint;
    private PlayerMovementController pmc;
    public AudioSource CheckpointSound;
    private GameObject Particle;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.tag == "Particle")
                Particle = child.gameObject;
        }
        pmc = FindObjectOfType<PlayerMovementController>();
        aIFollow = FindObjectOfType<Seek>();
        spawnPoint = gameObject.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pmc.spawnPoint = spawnPoint;
            CheckpointSound.Play();
            if (followPlayer)
            {
                aIFollow.follow = true;
                if (Particle != null)
                {
                    Destroy(Particle);
                }
            }
            else
            {
                aIFollow.follow = false;
                aIFollow.targetposition = levelposition;
                if (Particle != null)
                {
                    Destroy(Particle);
                }
            }
        }
    }
}