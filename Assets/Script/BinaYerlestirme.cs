using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaYerlestirme : MonoBehaviour
{
    public int enerjiMiktar = 1000;
    public int suMiktar = 1000;
    public int demirMiktar = 1000;

    //public GameObject bina1;
    //public GameObject bina2;
    //public GameObject bina3;


    public int bina1EnerjiMaliyet = 50;
    public int bina1SuMaliyet = 50;
    public int bina2DemirMaliyet = 50;
    public int bina2SuMaliyet = 50;
    public int bina3DemirMaliyet = 50;
    public int bina3EnerjiMaliyet = 50;

    public int bina1UretimMiktari = 10;
    public int bina2UretimMiktari = 20;
    public int bina3UretimMiktari = 20;

    private bool bina1Yerlestirildi = false;
    private bool bina2Yerlestirildi = false;
    private bool bina3Yerlestirildi = false;

    void Start()
    {
        StartCoroutine(UretimDongusu());
    }

    void Update()
    {
       
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    Bina1Yerlestir();
        //}

        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    Bina2Yerlestir();
        //}

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Bina3Yerlestir();
        //}
        Debug.Log(enerjiMiktar);
        Debug.Log(suMiktar);
        Debug.Log(demirMiktar);


    }

    void Bina1Yerlestir()
    {
        if (enerjiMiktar >= bina1EnerjiMaliyet && suMiktar >= bina1SuMaliyet && !bina1Yerlestirildi)
        {
            enerjiMiktar -= bina1EnerjiMaliyet;
            suMiktar -= bina1SuMaliyet;
            bina1Yerlestirildi = true;
        }
    }

    void Bina2Yerlestir()
    {
        if (demirMiktar >= bina2DemirMaliyet && suMiktar >= bina2SuMaliyet && !bina2Yerlestirildi)
        {
            demirMiktar -= bina2DemirMaliyet;
            suMiktar -= bina2SuMaliyet;
            bina2Yerlestirildi = true;
        }
    }

    void Bina3Yerlestir()
    {
        if (demirMiktar >= bina3DemirMaliyet && enerjiMiktar >= bina3EnerjiMaliyet && !bina3Yerlestirildi)
        {
            demirMiktar -= bina3DemirMaliyet;
            enerjiMiktar -= bina3EnerjiMaliyet;
            bina3Yerlestirildi = true;
        }
    }

    IEnumerator UretimDongusu()
    {
        while (true)
        {
            yield return new WaitForSeconds(5); // Her 60 saniyede bir çalýþýr (dakika bazýnda)

            if (bina1Yerlestirildi)
            {
                enerjiMiktar += bina1UretimMiktari;
            }

            if (bina2Yerlestirildi)
            {
                suMiktar += bina2UretimMiktari;
            }

            if (bina3Yerlestirildi)
            {
                demirMiktar += bina3UretimMiktari;
            }
        }
    }
    public void Bina1YerlestirButton()
    {
        //bina1.SetActive(true);
        Bina1Yerlestir();
    }
    public void Bina2YerlestirButton()
    {
        //bina2.SetActive(true);
        Bina2Yerlestir();
    }
    public void Bina3YerlestirButton()
    {
       //bina3.SetActive(true);
        Bina3Yerlestir();
    }
}
