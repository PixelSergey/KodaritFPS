using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float mouseX;
    public float mouseY;
    public Transform cameraTransform;

    [Header("Miten paljon pelaaja saa katsoa ylös/alas?")]
    public float maxX = 50f;
    public float minX = -50f;

    public float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // Lukitsee hiiren
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation = xRotation - mouseY;
        if(xRotation > maxX) xRotation = maxX;
        if(xRotation < minX) xRotation = minX;

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        cameraTransform.Rotate(Vector3.up * mouseX);
    }
}
