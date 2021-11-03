using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinished : MonoBehaviour
{
    private AIFollow aIFollow;


    // Start is called before the first frame update
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
