using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefabs;
    GameObject[] asteroids = new GameObject[4];
   
    void Update()
    {
      if(Input.GetMouseButtonDown(0))
      {
            Debug.Log(Input.mousePosition);

            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            asteroids[1] = Instantiate(asteroidPrefabs, position, Quaternion.identity);
            asteroids[0] = Instantiate(asteroidPrefabs, position, Quaternion.identity);
            asteroids[2] = Instantiate(asteroidPrefabs, position, Quaternion.identity);
            asteroids[3] = Instantiate(asteroidPrefabs, position, Quaternion.identity);
      }
    }
}
