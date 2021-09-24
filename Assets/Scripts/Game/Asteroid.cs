using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    float speed = 2;
    [SerializeField]
    GameObject destroyPrefab;

    GameManager gameManager;

    
    void Start()
    {
        gameManager = Camera.main.GetComponent<GameManager>();

        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();

        float yon = Random.Range(0f, 1f);

        if(yon < 0.5f)
        {
            //sol asagi yonde random bir guc uygular
            rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1f), Random.Range(-2.5f, -1f)) * speed, ForceMode2D.Impulse);
            rb2d.AddTorque(yon * 25f);
        }else
        {
            //sag asagi yonde random bir guc uygular
            rb2d.AddForce(new Vector2(Random.Range(1f, 2.5f), Random.Range(-2.5f, -1f)) * speed, ForceMode2D.Impulse);
            rb2d.AddTorque(-yon * 25f);
        }         
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            gameManager.AsteroidDestroyed(gameObject);
            Instantiate(destroyPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);      
        }
    }
   
}
