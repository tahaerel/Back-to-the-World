using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Movement : MonoBehaviour
{
    public float hiz = 5f; // Karakterin hareket h�z�

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 hedefPozisyon = GetMouseWorldPosition();

            hedefPozisyon.y = transform.position.y; // Karakterin y�ksekli�ini sabit tut
            transform.LookAt(hedefPozisyon); // Hedefe do�ru bak

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
