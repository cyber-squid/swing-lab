using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform player;
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        /*Decrease x rotation every frame with mouseY, if we make it + it flips it.*/
        xRotation -= mouseY;
        /*What this is doing is making it so we do not over rotate, so we, get accurate FPS rotation */
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        /*We using Euler, so we can get accurate rotations, since we do plan on clamping it. We use Euler for its euler angles.*/
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
