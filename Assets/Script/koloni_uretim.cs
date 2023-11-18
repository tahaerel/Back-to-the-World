using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koloni_uretim : MonoBehaviour
{
    private GameObject Gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        Gamemanager = GameObject.Find("GameManager");
        StartCoroutine(koloni_urett());
    }

    // Update is called once per frame
    IEnumerator koloni_urett()
    {
        while (true)
        {

            yield return new WaitForSeconds(5); // Her 60 saniyede bir çalýþýr (dakika bazýnda)
            Gamemanager.GetComponent<BinaYerlestirme>().kolonisayisi += 5;

        }
    }
}
