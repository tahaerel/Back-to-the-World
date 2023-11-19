using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceChanger : MonoBehaviour
{
    public GameObject Gamemanager;
    public int enerji,su,demir,yemek,koloni;
    public float zamanAraligi = 10f;
    public int Binaid;
    public bool is_stone;
    public bool is_water;
    
    void Start()
    {
      

        Gamemanager = GameObject.Find("GameManager");
        switch (Binaid)
        {
            case 0:
                InvokeRepeating("ArtirKoloni", zamanAraligi, zamanAraligi);
                break;

            case 1:
                InvokeRepeating("ArtirEnerji", zamanAraligi, zamanAraligi);
                break;
            case 2:
                InvokeRepeating("ArtirYemek", zamanAraligi, zamanAraligi);

                break;
            case 3:
                StartCoroutine(water_stonect());


                break;
        }
 
    }
    IEnumerator water_stonect()
    {
        yield return new WaitForSeconds(1.2f);
        if (is_water)
        {
            InvokeRepeating("ArtirSu", zamanAraligi, zamanAraligi);
            is_water = false;
        }

        else if (is_stone)
        {
            InvokeRepeating("Arttirdemir", zamanAraligi, zamanAraligi);
            is_stone = false;
        }
    }

  
    void ArtirKoloni()
    {
        Gamemanager.GetComponent<BinaYerlestirme>().kolonisayisi += koloni;

    }
    void ArtirEnerji()
    {
        Gamemanager.GetComponent<BinaYerlestirme>().enerjiMiktar += enerji;
  
    }

    void ArtirSu()
    {
        Gamemanager.GetComponent<BinaYerlestirme>().suMiktar += su;

    }
    void Arttirdemir()
    {
        Gamemanager.GetComponent<BinaYerlestirme>().demirMiktar+= demir;

    }
    void ArtirYemek()
    {
        Gamemanager.GetComponent<BinaYerlestirme>().yemekmiktar += yemek;

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "demir")
        {
            Debug.Log("Demirdesin");
            is_stone = true;
        }
        if (other.gameObject.tag == "su")
        {
            Debug.Log("Sudasýn");
            is_water = true;
        }
    }
}
