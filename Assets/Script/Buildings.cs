using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : MonoBehaviour
{
    RaycastHit hit;
    public GameObject olusacakbina1;


     void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray,out hit, 5000f,(1<<8)))
        {
            transform.position = new Vector3(hit.point.x, hit.point.y + .5f, hit.point.z);
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
            Instantiate(olusacakbina1, hit.point, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
