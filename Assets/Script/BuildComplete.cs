using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildComplete : MonoBehaviour
{
    public BinaYerlestirme kaynak;

    // Start is called before the first frame update
    void Start()
    {
        kaynak.enerjiMiktar -= 100;
    }

 
}
