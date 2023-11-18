//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class KaynakKontrol : MonoBehaviour
//{
//    public BinaYerlestirme bnb;


//    public static bool bina1_yerlestir;
//    public static bool bina2_yerlestir;
//    public static bool bina3_yerlestir;



   
    
//    public void Bina1Yerlestir()
//    {
//        if (bnb.enerjiMiktar >= bnb.bina1EnerjiMaliyet && bnb.suMiktar >= bnb.bina1SuMaliyet)
//        {
//            bina1_yerlestir = true;
//            bnb.enerjiMiktar -= bnb.bina1EnerjiMaliyet;
//            bnb.suMiktar -= bnb.bina1SuMaliyet;
//        }
//        else
//        {
//            bina1_yerlestir = false;
//        }
//    }
//    public void Bina2Yerlestir()
//    {
//        if (bnb.demirMiktar >= bnb.bina2DemirMaliyet && bnb.suMiktar >= bnb.bina2SuMaliyet)
//        {
//            bina2_yerlestir = true;
//            bnb.demirMiktar -= bnb.bina2DemirMaliyet;
//            bnb.suMiktar -= bnb.bina2SuMaliyet;
//        }
//        else
//        {
//            bina2_yerlestir = false;
//        }
//    }
//    public void Bina3Yerlestir()
//    {
//        if (bnb.demirMiktar >= bnb.bina3DemirMaliyet && bnb.enerjiMiktar >= bnb.bina3EnerjiMaliyet)
//        {
//            bina3_yerlestir = true;
//            bnb.demirMiktar -= bnb.bina3DemirMaliyet;
//            bnb.enerjiMiktar -= bnb.bina3EnerjiMaliyet;
//        }
//        else
//        {
//            bina3_yerlestir = false;
//        }
//    }
//}
