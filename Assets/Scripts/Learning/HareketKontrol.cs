using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketKontrol : MonoBehaviour
{
    [SerializeField]
    float forceSpeed = 5;

   
    private float colliderLengthHalf;
    private float colliderWidthHalf;


    // Start is called before the first frame update
    void Start()
    {

        Rigidbody2D myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.AddForce(new Vector2(Random.Range(2, 5), Random.Range(1,5)), ForceMode2D.Impulse);

        BoxCollider2D boxCollider2D = GetComponent<BoxCollider2D>();

        colliderLengthHalf = boxCollider2D.size.y / 2;
        colliderWidthHalf = boxCollider2D.size.x / 2;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kemerlerinizi Baglayin");
    }

    // Update is called once per frame


    void Update()
    {
        //Vector3 position = Input.mousePosition;
        //position.z = -Camera.main.transform.position.z;
        //position = Camera.main.ScreenToWorldPoint(position);

        //transform.position = position;

        StayOnTheScreen();

    }

    void StayOnTheScreen()
    {
        Vector3 position = transform.position;
        if (position.x - colliderWidthHalf < ScreenCalculator.Sol)
        {
            position.x = ScreenCalculator.Sol + colliderWidthHalf;
        }
        else if (position.x + colliderWidthHalf > ScreenCalculator.Sag)
        {
            position.x = ScreenCalculator.Sag - colliderWidthHalf;
        }
        if(position.y - colliderLengthHalf < ScreenCalculator.Asagi)
        {
            position.y = ScreenCalculator.Asagi + colliderLengthHalf;
        }
        else if(position.y + colliderLengthHalf > ScreenCalculator.Yukari)
        {
            position.y = ScreenCalculator.Yukari - colliderLengthHalf;
        }

        transform.position = position;
    }
}
