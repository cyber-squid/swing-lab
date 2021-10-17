using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappler : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private Vector3 grapplePoint;
    public LayerMask grappleObjects;
    public Transform gunTip, camera, player;
    private SpringJoint joint;
    private Vector3 currentGrapplePosition;
    private float maxDistance = 10f;

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartGrapple();
        }
        else if (Input.GetMouseButtonDown(0))
        {
            StopGrapple();
        }
    }
    void LateUpdate()
    {
        drawRope();
    }
    void StartGrapple()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.position, camera.forward, out hit, maxDistance, grappleObjects))
        {
            grapplePoint = hit.point;
            joint = player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplePoint;

            /*Here we can configure the distance the grapple will try to grapple from.*/
            float distanceFromPoint= Vector3.Distance(player.position, grapplePoint);
            joint.maxDistance = distanceFromPoint * 0.9f;
            joint.minDistance = distanceFromPoint * 0.20f;
            /*Changing these will basically change the stength of the pull and push of the grapple*/
            joint.spring = 5f;
            joint.damper = 8f;
            joint.massScale = 5f;

            lineRenderer.positionCount = 2;
            currentGrapplePosition = gunTip.position;
        }
    }
    void drawRope()
    {
        if(!joint) return;

        currentGrapplePosition = Vector3.Lerp(currentGrapplePosition, grapplePoint, Time.deltaTime * 8f);

        lineRenderer.SetPosition(0, gunTip.position);
        lineRenderer.SetPosition(0, currentGrapplePosition);
    }
    void StopGrapple()
    {
        lineRenderer.positionCount = 0;
        Destroy(joint);
    }

    public bool IsGrappling() {
        return joint != null;
    }

    public Vector3 GetGrapplePoint() {
        return grapplePoint;
    }
}
