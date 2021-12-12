using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinished : MonoBehaviour
{
    private Seek aIFollow;


    void Start()
    {
        aIFollow = FindObjectOfType<Seek>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            aIFollow.follow = true;
        }
    }
}
