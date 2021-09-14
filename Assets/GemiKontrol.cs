using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       






        //int bombacisayisi = 133;
        //if (bombacisayisi >= 20 && bombacisayisi <= 30)
        //{
        //    Debug.Log("Bombalandiniz");
        //}
        //else if (bombacisayisi > 30 && bombacisayisi <= 99)
        //{
        //    Debug.Log("Fena Bombalandiniz");
        //}
        //else if (bombacisayisi > 100 && bombacisayisi != 150)
        //{
        //    Debug.Log("Çok fena bombalandiniz");
        //}
        //else
        //{
        //    Debug.Log("Kazandiniz");
        //}

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kemerlerinizi Baglayin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
