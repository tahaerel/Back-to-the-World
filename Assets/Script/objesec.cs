using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objesec : MonoBehaviour
{
    public GameObject[] OnizlemeObjeler;
    public static bool butona_tiklandi;
    public BinaYerlestirme bnb;

    public static int index;

    public void olustur(int deger)
    {

        index = deger;

        switch (deger)
        {
            case 0:
                if (bnb.enerjiMiktar >= bnb.bina1EnerjiMaliyet && bnb.suMiktar >= bnb.bina1SuMaliyet)
                {
                    Instantiate(OnizlemeObjeler[deger]);


                    bnb.enerjiMiktar -= bnb.bina1EnerjiMaliyet;
                     bnb.suMiktar -= bnb.bina1SuMaliyet;
                }
               
                break;
            case 1:
                if (bnb.demirMiktar >= bnb.bina2DemirMaliyet && bnb.suMiktar >= bnb.bina2SuMaliyet)
                {
                    bnb.demirMiktar -= bnb.bina2DemirMaliyet;
                   bnb.suMiktar -= bnb.bina2SuMaliyet;
                    Instantiate(OnizlemeObjeler[deger]);
                }
                
                break;
            case 2:
                if (bnb.demirMiktar >= bnb.bina3DemirMaliyet && bnb.enerjiMiktar >= bnb.bina3EnerjiMaliyet)
                {
                    bnb.demirMiktar -= bnb.bina3DemirMaliyet;
                    bnb.enerjiMiktar -= bnb.bina3EnerjiMaliyet;
                    Instantiate(OnizlemeObjeler[deger]);
                }
                
                break;
            default:
                break;
        }
        
    }
}
