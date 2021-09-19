using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefabs;
    GameObject[] asteroids = new GameObject[4];

    List<GameObject> asteroidList = new List<GameObject>();
   
    void Update()
    {
      if(Input.GetMouseButtonDown(0))
      {
            Debug.Log(Input.mousePosition);

            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            for (int i = 0; i < 20; i++)
            {
                asteroidList.Add(Instantiate(asteroidPrefabs, position, Quaternion.identity));
            }

            
      }

        if (Input.GetMouseButtonDown(1))
        {
            for(int i = 0; i< asteroidList.Count; i++)
            {
                Destroy(asteroidList[i]);
            }
        }
    }

   
}
