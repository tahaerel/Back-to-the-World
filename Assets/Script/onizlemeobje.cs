using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onizlemeobje : MonoBehaviour
{
    public GameObject Olusacakobje;
    public float gridSize = 1.0f; // Kare boyutu
    RaycastHit hit;
    public Material materyal;
    bool olusturabilirmi;
    public MeshRenderer matcolor;

    void Start()
    {
        olusturabilirmi = true;
        UpdatePosition();
    }

    void UpdatePosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 5000f, (1 << 8)))
        {
            Vector3 gridPosition = hit.point;
            gridPosition.x = Mathf.Floor(gridPosition.x / gridSize) * gridSize + gridSize / 2;
            gridPosition.y = Mathf.Floor(gridPosition.y / gridSize) * gridSize + gridSize / 2;
            gridPosition.z = Mathf.Floor(gridPosition.z / gridSize) * gridSize + gridSize / 2;

            transform.position = gridPosition;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject != null && !other.gameObject.CompareTag("Zemin"))
        {
            Debug.Log("Çarpma var");

            GetComponent<MeshRenderer>().material.color = Color.red;

            for (int i = 0; i < matcolor.materials.Length; i++)
            {
                matcolor.materials[i].color = Color.red;
            }
            olusturabilirmi = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject != null && !other.gameObject.CompareTag("Zemin"))
        {
            GetComponent<MeshRenderer>().material = materyal;

            for (int i = 0; i < matcolor.materials.Length; i++)
            {
                matcolor.materials[i].CopyPropertiesFromMaterial(materyal);
            }
            olusturabilirmi = true;
        }
    }

    void Update()
    {
        UpdatePosition();

        if (Input.GetMouseButton(0))
        {
            if (olusturabilirmi)
            {
                Instantiate(Olusacakobje, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }

        if (Input.GetMouseButton(1))
        {
            Destroy(gameObject);
        }
    }
}
