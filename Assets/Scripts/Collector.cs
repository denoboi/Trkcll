using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField]
    GameObject starPrefab;

    List<GameObject> stars = new List<GameObject>();
  
    /// <summary>
    /// toplanmasi gereken yildizi soyleyecek olan property
    /// </summary>
    public GameObject TargetStar
    {
        get
        {
            if(stars.Count>0)
            {
                return stars[0];
            }else
            {
                return null;
            }
        }
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            stars.Add(Instantiate(starPrefab, position, Quaternion.identity));
        }     
    }

    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Destroy(gameObject);
    //}

    public void DestroyStar(GameObject yokEdilecekYildiz)
    {
        stars.Remove(yokEdilecekYildiz);
        Destroy(yokEdilecekYildiz);
    }
}
