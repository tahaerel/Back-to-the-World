using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float kameraHiz = 5f; // Kamera h�z�
    public float zoomHassasiyet = 2f; // Yak�nla�t�rma ve uzakla�t�rma hassasiyeti

    private bool sagaTikBasili = false;
    private Vector3 sagTikIlkKonum;

    void Update()
    {
        // WASD tu�lar�yla yatay hareket
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 hareket = new Vector3(yatay, 0f, dikey) * kameraHiz * Time.deltaTime;

        // Sa� t�klama durumunu kontrol et
        if (Input.GetMouseButtonDown(1))
        {
            sagaTikBasili = true;
            sagTikIlkKonum = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            sagaTikBasili = false;
        }

        // Sa� t�klama bas�l�ysa, kameray� yaln�zca yatay d�zlemde s�r�kleyerek hareket ettir
        if (sagaTikBasili)
        {
            Vector3 fareHareketi = Input.mousePosition - sagTikIlkKonum;
            sagTikIlkKonum = Input.mousePosition;

            transform.Translate(new Vector3(fareHareketi.x, 0f, fareHareketi.y) * kameraHiz * Time.deltaTime);
        }
        else
        {
            // Sa� t�klama bas�l� de�ilse, yatay d�zlemde hareketi uygula
            transform.Translate(new Vector3(yatay, 0f, dikey) * kameraHiz * Time.deltaTime);
        }

        // Mouse tekerle�i ile zoom in/out
        float zoom = Input.GetAxis("Mouse ScrollWheel") * zoomHassasiyet;
        transform.Translate(Vector3.forward * zoom);

        // Kamera s�n�rlar� (iste�e ba�l� olarak ekleyebilirsiniz)
        // �rne�in, transform.position.x veya transform.position.z'yi belirli bir s�n�ra k�s�tlayabilirsiniz.
    }
}
