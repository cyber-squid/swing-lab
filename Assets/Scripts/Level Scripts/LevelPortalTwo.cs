using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPortalTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            collider.transform.position = new Vector3(-16.33f, 15.9f, 15.45f);
        }
    }
}