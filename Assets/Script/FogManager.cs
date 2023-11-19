using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogManager : MonoBehaviour
{
    private float baslangicDegeri = 20f;
    private float hedefDeger = 200f;
    private float artisHizi = 1f;


    public void FogDistanceRover()
    {

        StartCoroutine(FogArttir());

    }

    System.Collections.IEnumerator FogArttir()
    {
        float suankiDeger = baslangicDegeri;

        while (suankiDeger < hedefDeger)
        {
            suankiDeger += artisHizi * Time.deltaTime;

            RenderSettings.fogStartDistance = suankiDeger;

            yield return null;
        }

        Debug.Log("Fog Start Distance Hedef");
    }






}
