using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    CountDownTimer countDown;

    

    // Start is called before the first frame update
    void Start()
    {
        //tek islem yapacagimiz icin referansini almadan direkt addforce ekliyoruz.
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        countDown = gameObject.AddComponent<CountDownTimer>();
        countDown.TotalTime = 3;
        countDown.Run();

    }


    // Update is called once per frame
    void Update()
    {
        if(countDown.Over)
        {
            Destroy(gameObject);
        }
    }
}
