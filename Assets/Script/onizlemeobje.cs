using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onizlemeobje : MonoBehaviour
{
    public GameObject Olusacakobje;
    RaycastHit hit;
    public Material materyal,materyal2;
    bool olusturabilirmi;
    public MeshRenderer matcolor;


    void Start()
    {
        olusturabilirmi = true;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray,out hit,5000f,(1<<8)))
        {

            //  transform.position = hit.point;
            transform.position = new Vector3(hit.point.x, hit.point.y + .5f, hit.point.z);
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
                
            matcolor.materials[i].color= Color.red;
            }
            olusturabilirmi = false;

        }
        else
        {
            for (int j = 0; j < matcolor.materials.Length; j++)
            {

                matcolor.materials[j] = materyal;
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject != null && !other.gameObject.CompareTag("Zemin"))
        {
            GetComponent<MeshRenderer>().material = materyal;
            for (int i = 0; i < matcolor.materials.Length; i++)
            {
                matcolor.materials[i] = materyal2;
                Debug.Log("material2: " + matcolor.materials[i].name);
            }
            olusturabilirmi = true;
            
        }
    }

   

    void Update()
    {


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 5000f, (1 << 8)))
        {

            transform.position = new Vector3(hit.point.x, hit.point.y + .5f, hit.point.z);

        }

        if (Input.GetMouseButton(0))
        {

            if (olusturabilirmi)
            {
                Instantiate(Olusacakobje, transform.position, transform.rotation);
                Destroy(gameObject);
               


            }



        }
    }
}
