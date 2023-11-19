using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objesec : MonoBehaviour
{
    public GameObject[] OnizlemeObjeler;
    public static bool butona_tiklandi;
    public BinaYerlestirme bnb;
    public GameObject Error;
    public static int index;

    public void olustur(int deger)
    {

        index = deger;

        switch (deger)
        {
            case 0:
                if (bnb.enerjiMiktar >= bnb.bina1EnerjiMaliyet && bnb.demirMiktar >= bnb.bina1DemirMaliyet && bnb.yemekmiktar >= bnb.bina1YemekMaliyet)
                {
                    Instantiate(OnizlemeObjeler[deger]);


                    bnb.enerjiMiktar -= bnb.bina1EnerjiMaliyet;
                    bnb.demirMiktar -= bnb.bina1DemirMaliyet;
                    bnb.yemekmiktar -= bnb.bina1YemekMaliyet;
                }
                else
                {
                    Error.SetActive(true);
                    StartCoroutine(DeactivateErrorAfterDelay(1.5f));
                }
                break;
            case 1:
                if (bnb.demirMiktar >= bnb.bina2DemirMaliyet)
                {
                    bnb.demirMiktar -= bnb.bina2DemirMaliyet;
                  
                    Instantiate(OnizlemeObjeler[deger]);
                }
                else
                {
                    Error.SetActive(true);
                    StartCoroutine(DeactivateErrorAfterDelay(1.5f));

                }
                break;
            case 2:
                if (bnb.demirMiktar >= bnb.bina3DemirMaliyet && bnb.enerjiMiktar >= bnb.bina3EnerjiMaliyet && bnb.suMiktar >= bnb.bina3SuMaliyet && bnb.kolonisayisi >= bnb.bina3KoloniMaliyet)
                {
                    bnb.demirMiktar -= bnb.bina3DemirMaliyet;
                    bnb.enerjiMiktar -= bnb.bina3EnerjiMaliyet;
                    bnb.suMiktar -= bnb.bina3SuMaliyet;
                    bnb.kolonisayisi -= bnb.bina3KoloniMaliyet;
                    Instantiate(OnizlemeObjeler[deger]);
                }

                else
                {
                    Error.SetActive(true);
                    StartCoroutine(DeactivateErrorAfterDelay(1.5f));

                }
                break;
            case 3:

                if (bnb.demirMiktar >= bnb.bina4DemirMaliyet && bnb.kolonisayisi >= bnb.bina4koloniMaliyet && bnb.enerjiMiktar >= bnb.bina4EnergyMaliyet)
                {
                    bnb.demirMiktar -= bnb.bina4DemirMaliyet;
                    bnb.kolonisayisi -= bnb.bina4koloniMaliyet;
                    bnb.enerjiMiktar -= bnb.bina4EnergyMaliyet;
                
                    Instantiate(OnizlemeObjeler[deger]);
                }
                else
                {
                    Error.SetActive(true);
                    StartCoroutine(DeactivateErrorAfterDelay(1.5f));

                }

                break;
            case 4:
                
                    if (bnb.demirMiktar >= bnb.bina5demirMmaliyet && bnb.enerjiMiktar >= bnb.bina5yenergyMaliyet && bnb.suMiktar >= bnb.bina5ySuMaliyet && bnb.kolonisayisi >= bnb.bina5KoloniMaliyet)
                    {   
                    bnb.demirMiktar -= bnb.bina5demirMmaliyet;
                    bnb.enerjiMiktar -= bnb.bina5yenergyMaliyet;
                    bnb.suMiktar -= bnb.bina5ySuMaliyet;
                    bnb.kolonisayisi -= bnb.bina5KoloniMaliyet;
                    Instantiate(OnizlemeObjeler[deger]);
                    }
                else
                {
                    Error.SetActive(true);
                    StartCoroutine(DeactivateErrorAfterDelay(1.5f));

                }


                break;
         
            default:

                break;
        }

    }

    IEnumerator DeactivateErrorAfterDelay(float delay)
    {  
        yield return new WaitForSeconds(delay);

        Error.SetActive(false);
    }



}
