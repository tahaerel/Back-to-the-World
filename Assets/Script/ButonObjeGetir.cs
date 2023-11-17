using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonObjeGetir : MonoBehaviour
{
    public GameObject Bina1_onizleme;
    public void Bina1_Olustur()
    {
        Instantiate(Bina1_onizleme);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
