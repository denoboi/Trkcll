using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField]
    GameObject starPrefab;

    List<GameObject> stars = new List<GameObject>();
  
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

    // Update is called once per frame
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

    public void DestroyStar(GameObject yokEdilecekYildiz)
    {
        stars.Remove(yokEdilecekYildiz);
    }
}
