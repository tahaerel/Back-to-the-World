using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demir_Uretim : MonoBehaviour
{
    private GameObject Gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        Gamemanager = GameObject.Find("GameManager");
        StartCoroutine(Demir_Uretimm());
    }

    // Update is called once per frame
    IEnumerator Demir_Uretimm()
    {
        while (true)
        {

            yield return new WaitForSeconds(5); // Her 60 saniyede bir çalýþýr (dakika bazýnda)
            Gamemanager.GetComponent<BinaYerlestirme>().demirMiktar += 5;

        }
    }
}
