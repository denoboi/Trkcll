using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //tek islem yapacagimiz icin referansini almadan direkt addforce ekliyoruz.
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
