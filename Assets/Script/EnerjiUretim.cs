using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnerjiUretim : MonoBehaviour
{
    private GameObject Gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        Gamemanager = GameObject.Find("GameManager");
        StartCoroutine(EnerjiUretimi());
    }

    // Update is called once per frame
    IEnumerator EnerjiUretimi()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(5); // Her 60 saniyede bir çalýþýr (dakika bazýnda)
            Gamemanager.GetComponent<BinaYerlestirme>().enerjiMiktar += 5;

        }
    }
}
