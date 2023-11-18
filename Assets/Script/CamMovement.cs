using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float kameraHiz = 5f; // Kamera hýzý
    public float zoomHassasiyet = 2f; // Yakýnlaþtýrma ve uzaklaþtýrma hassasiyeti

    private bool sagaTikBasili = false;
    private Vector3 sagTikIlkKonum;

    void Update()
    {
        // WASD tuþlarýyla yatay hareket
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 hareket = new Vector3(yatay, 0f, dikey) * kameraHiz * Time.deltaTime;

        // Sað týklama durumunu kontrol et
        if (Input.GetMouseButtonDown(1))
        {
            sagaTikBasili = true;
            sagTikIlkKonum = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            sagaTikBasili = false;
        }

        // Sað týklama basýlýysa, kamerayý yalnýzca yatay düzlemde sürükleyerek hareket ettir
        if (sagaTikBasili)
        {
            Vector3 fareHareketi = Input.mousePosition - sagTikIlkKonum;
            sagTikIlkKonum = Input.mousePosition;

            transform.Translate(new Vector3(fareHareketi.x, 0f, fareHareketi.y) * kameraHiz * Time.deltaTime);
        }
        else
        {
            // Sað týklama basýlý deðilse, yatay düzlemde hareketi uygula
            transform.Translate(new Vector3(yatay, 0f, dikey) * kameraHiz * Time.deltaTime);
        }

        // Mouse tekerleði ile zoom in/out
        float zoom = Input.GetAxis("Mouse ScrollWheel") * zoomHassasiyet;
        transform.Translate(Vector3.forward * zoom);

        // Kamera sýnýrlarý (isteðe baðlý olarak ekleyebilirsiniz)
        // Örneðin, transform.position.x veya transform.position.z'yi belirli bir sýnýra kýsýtlayabilirsiniz.
    }
}
