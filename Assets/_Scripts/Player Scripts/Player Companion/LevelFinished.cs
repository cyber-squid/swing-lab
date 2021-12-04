using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinished : MonoBehaviour
{
    private AIFollow aIFollow;


    void Start()
    {
        aIFollow = FindObjectOfType<AIFollow>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            aIFollow.follow = true;
            aIFollow.goTolevelposition = false;
        }
    }
}
