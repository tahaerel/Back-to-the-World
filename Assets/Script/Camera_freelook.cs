
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Camera_freelook : MonoBehaviour
{
    public float panSpeed = 5f; // Pan speed

    void Update()
    {
        // WASD tuþlarýyla yatay hareket
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 hareket = new Vector3(yatay, 0f, dikey) * panSpeed * Time.deltaTime;

        // Check if the right mouse button is held down
        if (Input.GetMouseButton(1))
        {
            // Call the function to handle camera panning
            PanCamera();
        }
    }

    void PanCamera()
    {
        // Get the mouse movement in the horizontal and vertical axes
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calculate the pan direction
        Vector3 panDirection = new Vector3(mouseX, 0f, mouseY).normalized;

        // Move the camera in the pan direction
        transform.Translate(panDirection * panSpeed * Time.deltaTime, Space.World);
    }
}