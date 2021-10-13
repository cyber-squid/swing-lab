using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public Animation Hinge;
    public AudioClip DoorSound;
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Player")
        {
            Hinge.Play();
            audio = GetComponent<AudioSource>();
            audio.clip = DoorSound;
            audio.Play();
        }
    }
}
