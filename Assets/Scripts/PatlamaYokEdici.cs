using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaYokEdici : MonoBehaviour
{
    
    CountDownTimer patlamaCountdownTimer;

    SiraliYokEdici siraliYokEdici;
    void Start()
    {


        patlamaCountdownTimer = gameObject.AddComponent<CountDownTimer>();
        patlamaCountdownTimer.TotalTime = 0.9f;
        patlamaCountdownTimer.Run();

        siraliYokEdici = Camera.main.GetComponent<SiraliYokEdici>();
                   
    }

    // Update is called once per frame
    void Update()
    {
        if (patlamaCountdownTimer.Over)
        {
            siraliYokEdici.DestroyTarget();
            Destroy(gameObject);
        }
    }
}
