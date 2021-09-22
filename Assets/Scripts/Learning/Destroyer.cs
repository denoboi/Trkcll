using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject destroyPrefab;

    CountDownTimer destroyerCountdownTimer;

    void Start()
    {

        destroyerCountdownTimer = gameObject.AddComponent<CountDownTimer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(destroyerCountdownTimer.Over)
        {
            
            GameObject explosion =  Instantiate(destroyPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            //Destroy(explosion);  //bu cok hizli explosion yapiyor, sprite'i goremiyoruz bile.
            

        }
    }

    public void AsteroidDestroyer(float sure)
    {
        destroyerCountdownTimer.TotalTime = Random.Range(1, 5);
        destroyerCountdownTimer.Run();
    }
}
