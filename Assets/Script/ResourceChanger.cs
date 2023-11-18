using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceChanger : MonoBehaviour
{
    public GameObject Gamemanager;
   public int enerji;

    void Start()
    {
        

        Gamemanager = GameObject.Find("GameManager");
      

       // Gamemanager.GetComponent<BinaYerlestirme>().enerjiMiktar -= 100;
   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
