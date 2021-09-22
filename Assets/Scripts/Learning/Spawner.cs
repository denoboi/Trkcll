using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    CountDownTimer countdownTimer;

    // Start is called before the first frame update
    void Start()
    {
        //bu scriptin oldugu oyun objesine dinamik olarak countdown timer ekliyoruz.
        countdownTimer = gameObject.AddComponent<CountDownTimer>();
        countdownTimer.TotalTime = 3;
        countdownTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
       if(countdownTimer.Over)
        {
            Instantiate(asteroidPrefab);
            countdownTimer.Run();
        }
    }
}
