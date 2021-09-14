using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaYokEdici : MonoBehaviour
{
    
    CountDownTimer patlamaCountdownTimer;
    void Start()
    {
        patlamaCountdownTimer = gameObject.AddComponent<CountDownTimer>();
        patlamaCountdownTimer.TotalTime = 0.9f;
        patlamaCountdownTimer.Run();
                   
    }

    // Update is called once per frame
    void Update()
    {
        if (patlamaCountdownTimer.Over)
        {
            Destroy(gameObject);
        }
    }
}
