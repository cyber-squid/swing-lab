using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPortalThree : MonoBehaviour
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
            collider.transform.position = new Vector3(369.57f, 50f, -899.9999f);
        }
    }
}