using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hesaplamalar : MonoBehaviour
{
    private static int _puan;

    private static int istenilenPuan;
    private static int can=2;
    private static bool durum=true;

    public static void PuanArttir()
    {
        _puan++;
    }

    public static bool durumGoster()
    {
        return durum;
    }
    
    public static void durumDegistir()
    {
        if (durum==false){
            durum=true;
        }else{
            durum=false;
        }
    }
    public static int puanGoster()
    {
        return _puan;
    }
    public static void puanAzalt()
    {
        _puan--;
    }
    public static void canFulle()
    {
        _puan=0;
        can=2;
    }
    public static int canGoster()
    {
        return can;
    }
    public static void canAzalt()
    {
        can--;
    }

    public static int istenilenPuann(){
        return istenilenPuan;
    }
}


