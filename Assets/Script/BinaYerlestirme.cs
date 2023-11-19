using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaYerlestirme : MonoBehaviour
{
    public int enerjiMiktar = 10;
    public int suMiktar = 50;
    public int demirMiktar = 1;
    public int yemekmiktar = 1;
    public int kolonisayisi = 1;


    public int bina1EnerjiMaliyet = 250;
    public int bina1DemirMaliyet = 150;
    public int bina1YemekMaliyet = 100;

    public int bina2DemirMaliyet = 20;
    


    public int bina3DemirMaliyet = 100;
    public int bina3EnerjiMaliyet = 10;
    public int bina3SuMaliyet= 50;
    public int bina3KoloniMaliyet = 2;


    public int bina4DemirMaliyet = 50;
    public int bina4EnergyMaliyet = 20;
    public int bina4koloniMaliyet = 1;

    public int bina5demirMmaliyet = 500;
    public int bina5yenergyMaliyet = 100;
    public int bina5ySuMaliyet = 200;
    public int bina5KoloniMaliyet = 20;

    public int bina1UretimMiktari = 10;
    public int bina2UretimMiktari = 20;
    public int bina3UretimMiktari = 20;
    public int bina4UretimMiktari = 20;
    public int bina5UretimMiktari = 20;

    //private bool bina1Yerlestirildi = false;
    //private bool bina2Yerlestirildi = false;
    //private bool bina3Yerlestirildi = false;
    //private bool bina4Yerlestirildi = false;
    //private bool bina5Yerlestirildi = false;

    //void Start()
    //{
    //    StartCoroutine(UretimDongusu());
    //}

    

    //void Bina1Yerlestir()
    //{
    //    Debug.Log("Bina1Yerlestir");
    //    if (enerjiMiktar >= bina1EnerjiMaliyet && demirMiktar >= bina1DemirMaliyet && yemekmiktar >= bina1YemekMaliyet && !bina1Yerlestirildi)
    //    {
    //        Debug.Log("Bina1Yerlestirifici");

    //        enerjiMiktar -= bina1EnerjiMaliyet;
    //        demirMiktar -= bina1DemirMaliyet;
    //        yemekmiktar -= bina1YemekMaliyet;
    //        bina1Yerlestirildi = true;
    //        Debug.Log("miktar azaldý");

    //    }
    //}

    //void Bina2Yerlestir()
    //{
    //    Debug.Log("Bina2Yerlestir");

    //    if (demirMiktar >= bina2DemirMaliyet )
    //    {
    //        demirMiktar -= bina2DemirMaliyet;
            
    //        bina2Yerlestirildi = true;
    //    }
    //}

    //void Bina3Yerlestir()
    //{
    //    if (demirMiktar >= bina3DemirMaliyet && enerjiMiktar >= bina3EnerjiMaliyet && suMiktar >= bina3SuMaliyet && kolonisayisi>= bina3KoloniMaliyet )
    //    {
    //        demirMiktar -= bina3DemirMaliyet;
    //        enerjiMiktar -= bina3EnerjiMaliyet;
    //        suMiktar -= bina3SuMaliyet;
    //        kolonisayisi-= bina3KoloniMaliyet;
    //        bina3Yerlestirildi = true;
    //    }
    //}
    //void Bina4Yerlestir()
    //{
    //    if (demirMiktar >= bina4DemirMaliyet && kolonisayisi >= bina4koloniMaliyet &&  enerjiMiktar >= bina4EnergyMaliyet)
    //    {
    //        kolonisayisi -= bina4koloniMaliyet;
    //        demirMiktar -= bina4DemirMaliyet;
    //        enerjiMiktar -= bina4EnergyMaliyet;
    //        bina4Yerlestirildi = true;
    //    }
    //}
    //void Bina5Yerlestir()
    //{
    //    if (demirMiktar >= bina5demirMmaliyet && enerjiMiktar >= bina5yenergyMaliyet && suMiktar >= bina5ySuMaliyet && kolonisayisi >= bina5KoloniMaliyet)
    //    {
    //        demirMiktar -= bina5demirMmaliyet;
    //        enerjiMiktar -= bina5yenergyMaliyet;
    //        suMiktar -= bina5ySuMaliyet;
    //        kolonisayisi -= bina5KoloniMaliyet;
    //        bina5Yerlestirildi = true;
    //    }
    //}

    //IEnumerator UretimDongusu()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(5); 

    //        if (bina1Yerlestirildi)
    //        {
    //            enerjiMiktar += bina1UretimMiktari;
    //        }

    //        if (bina2Yerlestirildi)
    //        {
    //            suMiktar += bina2UretimMiktari;
    //        }

    //        if (bina3Yerlestirildi)
    //        {
    //            demirMiktar += bina3UretimMiktari;
    //        }
    //    }
    //}
    //public void Bina1YerlestirButton()
    //{
    //    //bina1.SetActive(true);
    //    Bina1Yerlestir();
    //}
    //public void Bina2YerlestirButton()
    //{
    //    //bina2.SetActive(true);
    //    Bina2Yerlestir();
    //}
    //public void Bina3YerlestirButton()
    //{
    //   //bina3.SetActive(true);
    //    Bina3Yerlestir();
    //}
}
