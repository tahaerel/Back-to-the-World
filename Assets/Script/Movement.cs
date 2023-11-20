using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Movement : MonoBehaviour
{
    public float hiz = 5f; // Karakterin hareket hýzý

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 hedefPozisyon = GetMouseWorldPosition();

            hedefPozisyon.y = transform.position.y; // Karakterin yüksekliðini sabit tut
            transform.LookAt(hedefPozisyon); // Hedefe doðru bak

            transform.Translate(Vector3.forward * hiz * Time.deltaTime);
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }

        return Vector3.zero;
    }
}
