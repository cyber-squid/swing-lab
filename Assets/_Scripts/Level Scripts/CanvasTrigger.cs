using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasTrigger : MonoBehaviour
{

    public Canvas myCanvas;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            myCanvas.enabled = true;
        }
    }

    void OnTriggerExit()
    {
        myCanvas.enabled = false;
    }
}




//If you want to be more specific to what gets enabled and store it all in one script you can check tags

//void OnTriggerEnter(Collider other)
//{
//   if (collider.tag == "NPCName")
//    {
//        myCanvas.enabled = true;
//    }
//} 