using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceChanger : MonoBehaviour
{
    public GameObject Gamemanager;
    public int enerji,su,demir,yemek,koloni;
    public float zamanAraligi = 10f;
    public int Binaid;

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

                InvokeRepeating("ArtirSu", zamanAraligi, zamanAraligi);

                InvokeRepeating("Arttirdemir", zamanAraligi, zamanAraligi);

                break;
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
}
