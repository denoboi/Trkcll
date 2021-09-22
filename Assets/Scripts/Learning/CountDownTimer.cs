using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
    float totalTime = 0;
    float passedTime = 0;
    bool isRunning = false;
    bool isStarted = false;

    public float TotalTime
    {
        //degiskene direkt erisim olmasin, sayac calisirken degistirme yapilamasin diye get kullaniyoruz.
        set
        {
            if(!isRunning)
            {
                totalTime = value;
            }
        }
       
    }

    //geri sayimin bitip bitmedigini soyler
    public bool Over
    {
        get
        {
            return isStarted && !isRunning;
        }
    }

    //sayaci calistirir
    public void Run()
    {
        if(totalTime > 0)
        {
            passedTime = 0;
            isRunning = true;
            isStarted = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isRunning)
        {
            passedTime += Time.deltaTime;
            if (passedTime >= totalTime)
            {
                isRunning = false;
            }
        }
    }
}
