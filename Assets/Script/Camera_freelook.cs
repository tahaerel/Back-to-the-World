
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

        Vector3 hareket = new Vector3(-dikey, 0f, yatay) * panSpeed*5 * Time.deltaTime;
        transform.Translate(hareket * panSpeed * Time.deltaTime, Space.World);

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
        Vector3 panDirection = new Vector3(mouseY, 0f, -mouseX ).normalized;

        // Move the camera in the pan direction
        transform.Translate(panDirection * panSpeed * Time.deltaTime, Space.World);
    }
}