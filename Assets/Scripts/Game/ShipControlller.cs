using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControlller : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;

    const float moveSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalControl = Input.GetAxis("Horizontal");
        float verticalControl = Input.GetAxis("Vertical");

        Vector3 position = transform.position;

        if (horizontalControl != 0)
        {
            position.x += horizontalControl * moveSpeed * Time.deltaTime;
        }

        transform.position = position;

        if (verticalControl != 0)
        {
            position.y += verticalControl * moveSpeed * Time.deltaTime;
        }

        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }

    
}
