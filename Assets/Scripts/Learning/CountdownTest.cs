
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTest : MonoBehaviour
{

    CountDownTimer countDown;
    float startingTime;

    // Start is called before the first frame update
    void Start()
    {
        countDown = gameObject.AddComponent<CountDownTimer>();
        countDown.TotalTime = 3;
        countDown.Run();

        startingTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(countDown.Over)
        {
            float passedTime = Time.time - startingTime;
            Debug.Log(passedTime);

            countDown.Run();
        }
    }
}
