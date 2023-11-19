using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Movement : MonoBehaviour
{
    public float hiz = 5f; // Karakterin hareket hýzý

    void Update()
    {
        // Mouse sol týklamasýný kontrol et
        if (Input.GetMouseButton(0))
        {
            // Mouse pozisyonunu al
            Vector3 hedefPozisyon = GetMouseWorldPosition();

            // Karakterin mevcut pozisyonunu ve hedef pozisyonu birleþtir
            hedefPozisyon.y = transform.position.y; // Karakterin yüksekliðini sabit tut
            transform.LookAt(hedefPozisyon); // Hedefe doðru bak

            // Karakteri hedef pozisyona doðru hareket ettir
            transform.Translate(Vector3.forward * hiz * Time.deltaTime);
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        // Mouse pozisyonunu ekran koordinatlarýndan dünya koordinatlarýna çevir
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }

        return Vector3.zero;
    }
}
