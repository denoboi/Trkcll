using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControlller : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab = default;

    [SerializeField]
    GameObject explosionPrefab = default;

    const float moveSpeed = 15;

    UIController uiController;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        uiController = Camera.main.GetComponent<UIController>();
        gameManager = Camera.main.GetComponent<GameManager>();
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
            
            Vector3 bulletPos = transform.position;
            //Instantiate methodu Vector3 alip sadece transform.position aldigi icin pozisyonu mecburen referans almaliydik baska turlu olmuyor
            bulletPos.y += 1f;
            Instantiate(bulletPrefab, bulletPos, Quaternion.identity);
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SoundControl>().FireSound();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            uiController.GameOver();
            gameManager.GameOver();
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SoundControl>().ShipDestroySound();
        }
    }


}

