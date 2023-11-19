using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Su_Uretim : MonoBehaviour
{
    private GameObject Gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        Gamemanager = GameObject.Find("GameManager");
        StartCoroutine(Su_Uretimi());
    }

    // Update is called once per frame
    IEnumerator Su_Uretimi()
    {
        while (true)
        {

            yield return new WaitForSeconds(5); // Her 60 saniyede bir çalýþýr (dakika bazýnda)
            Gamemanager.GetComponent<BinaYerlestirme>().suMiktar += 5;

        }
    }
}
