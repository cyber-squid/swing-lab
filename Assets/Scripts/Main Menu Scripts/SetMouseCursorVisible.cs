using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMouseCursorVisible : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; // fixed typo.
    }
}
