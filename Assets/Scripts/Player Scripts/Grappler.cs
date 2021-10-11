using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappler : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private Transform GrapleStart;

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartGrapple();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            StopGrapple();
        }
    }

    void StartGrapple()
    {

    }

    void StopGrapple()
    {

    }
}
