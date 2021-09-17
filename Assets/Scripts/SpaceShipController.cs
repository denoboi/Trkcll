using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    const float moveSpeed = 10;
   
    void Update()
    {
        float horizontalControl = Input.GetAxis("Horizontal");
        float verticalControl = Input.GetAxis("Vertical");

        Vector3 position = transform.position;

        if(horizontalControl != 0)
        {
           position.x += horizontalControl * moveSpeed * Time.deltaTime;
        }

        transform.position = position;

        if(verticalControl != 0)
        {
            position.y += verticalControl * moveSpeed * Time.deltaTime;
        }

        transform.position = position;




    }

}
