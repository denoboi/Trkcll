using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenCalculator
{
    static float yukari;
    static float asagi;
    static float sol;
    static float sag;

    public static float Yukari
    {
        get
        {
            return yukari;
        }
    }

    public static float Asagi
    {
        get
        {
            return asagi;
        }
    }
    public static float Sol
    {
        get
        {
            return sol;

        }
    }
    public static float Sag
    {
        get
        {
            return sag;
        }
    }

    public static void Init()
    {
        float ekranZekseni = -Camera.main.transform.position.z;
        Vector3 solAltKose = new Vector3(0, 0, ekranZekseni); // sol alt kosenin 0 0 oldugnu biliyoruz.
        Vector3 sagUstKose = new Vector3(Screen.width, Screen.height, ekranZekseni);

        Vector3 solAltKoseGameWorld = Camera.main.ScreenToWorldPoint(solAltKose);
        Vector3 sagUstKoseGameWorld = Camera.main.ScreenToWorldPoint(sagUstKose);

        sol = solAltKoseGameWorld.x;
        sag = sagUstKoseGameWorld.x;
        yukari = sagUstKoseGameWorld.y;
        asagi = solAltKoseGameWorld.y;
    }
}
