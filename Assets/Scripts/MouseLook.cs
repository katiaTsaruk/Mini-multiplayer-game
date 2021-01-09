using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class MouseLook : MonoBehaviour
{    
    public float mouseSensitivity;

    private void Start()
    {
        CameraRotation();
    }
    void Update()
    {

        CameraRotation();

    }
    void CameraRotation()
    {
        float mouseY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * mouseSensitivity;
        this.transform.localEulerAngles = new Vector3(mouseX, mouseY, 0f);
    }
}