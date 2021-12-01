using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOnePortal : MonoBehaviour
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
            collider.transform.position = new Vector3(-0.7290763f, 15.73784f, -24.09552f);
        }
    }
}
