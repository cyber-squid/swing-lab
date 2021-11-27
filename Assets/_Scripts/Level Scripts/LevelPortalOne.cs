using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPortalOne : MonoBehaviour
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
            collider.transform.position = new Vector3(-359.1363f, 2f, -493.3212f);
        }
    }
}