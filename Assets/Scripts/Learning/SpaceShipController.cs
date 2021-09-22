using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    const float moveSpeed = 5;

    bool isCollecting = false;

    GameObject target;

    Rigidbody2D myRigidbody2D;

    Collector collector;

    private void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        collector = Camera.main.GetComponent<Collector>();
    }

    void OnMouseDown()
    {
        if(!isCollecting)
        {
            GoAndCollect();
        }
    }

    /// <summary>
    /// eger colliderlar degdiginde bu hedefteki yildizsa yok et, yani topla, daha sonra geminin hizini sifir yap, sonra da baska toplanacak varsa go and collect yap.
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if(collision.gameObject == target)
        {
            collector.DestroyStar(target);
            myRigidbody2D.velocity = Vector2.zero;
            GoAndCollect();
        }
    }



    private void GoAndCollect()
    {
        target = collector.TargetStar;
        if (target != null)
        {
            Vector2 gidilecekYer = new Vector2(target.transform.position.x - transform.position.x, 
                target.transform.position.y - transform.position.y);
            gidilecekYer.Normalize();
            myRigidbody2D.AddForce(gidilecekYer * moveSpeed, ForceMode2D.Impulse);
        }
    }

    void Update()
    {
        //float horizontalControl = Input.GetAxis("Horizontal");
        //float verticalControl = Input.GetAxis("Vertical");

        //Vector3 position = transform.position;

        //if(horizontalControl != 0)
        //{
        //   position.x += horizontalControl * moveSpeed * Time.deltaTime;
        //}

        //transform.position = position;

        //if(verticalControl != 0)
        //{
        //    position.y += verticalControl * moveSpeed * Time.deltaTime;
        //}

        //transform.position = position;




    }

}
