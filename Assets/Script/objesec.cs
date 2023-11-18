using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objesec : MonoBehaviour
{
    public GameObject[] OnizlemeObjeler;
   public void olustur(int deger)
    {

        Instantiate(OnizlemeObjeler[deger]);
    }
}
