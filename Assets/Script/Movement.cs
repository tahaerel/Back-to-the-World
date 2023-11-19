using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Movement : MonoBehaviour
{
    public float hiz = 5f; // Karakterin hareket h�z�

    void Update()
    {
        // Mouse sol t�klamas�n� kontrol et
        if (Input.GetMouseButton(0))
        {
            // Mouse pozisyonunu al
            Vector3 hedefPozisyon = GetMouseWorldPosition();

            // Karakterin mevcut pozisyonunu ve hedef pozisyonu birle�tir
            hedefPozisyon.y = transform.position.y; // Karakterin y�ksekli�ini sabit tut
            transform.LookAt(hedefPozisyon); // Hedefe do�ru bak

            // Karakteri hedef pozisyona do�ru hareket ettir
            transform.Translate(Vector3.forward * hiz * Time.deltaTime);
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        // Mouse pozisyonunu ekran koordinatlar�ndan d�nya koordinatlar�na �evir
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }

        return Vector3.zero;
    }
}
