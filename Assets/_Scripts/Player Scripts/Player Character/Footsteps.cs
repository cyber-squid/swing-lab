using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour
{

    private PlayerMovementController pmc;
    public AudioSource footSteps;
    void Start()
    {
        pmc = FindObjectOfType<PlayerMovementController>();
    }

    void Update()
    {

        if (pmc.grounded && footSteps.isPlaying == false)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
                footSteps.Play();
        }
    }
}
