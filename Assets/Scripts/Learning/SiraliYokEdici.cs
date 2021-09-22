using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiraliYokEdici : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    GameObject spaceShip;

    List<GameObject> asteroidList = new List<GameObject>();

    GameObject targetAsteroid; // her defasinda 1 adet asteroid olacagi icin

    // Start is called before the first frame update
    void Start()
    {
        spaceShip = GameObject.FindGameObjectWithTag("Player");
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            GameObject asteroid = Instantiate(asteroidPrefab, position, Quaternion.identity);

            asteroidList.Add(asteroid);
        }

        if(Input.GetMouseButtonDown(1))
        {
            DestroyTarget();
        }
    }

    GameObject ClosestAsteroid()
    {
        GameObject closestAsteroid;
        float closestDistance;

        if(asteroidList.Count == 0)
        {
            return null;
        }else
        {
            closestAsteroid = asteroidList[0];
            closestDistance = MesafeOlcer(closestAsteroid);
        }

       //burada eger daha yakin bir asteroid varsa onu en yakin olarak kabul ediyor.
        foreach (GameObject asteroid in asteroidList)
        {
            float distance = MesafeOlcer(asteroid);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestAsteroid = asteroid;
            }
        }

        return closestAsteroid;
    }

    float MesafeOlcer(GameObject target)
    {
        return Vector3.Distance(spaceShip.transform.position, target.transform.position);
    }

    public void DestroyTarget()
    {
        targetAsteroid = ClosestAsteroid();
        if(targetAsteroid != null)
        {
            targetAsteroid.GetComponent<Destroyer>().AsteroidDestroyer(0.1f);
            asteroidList.Remove(targetAsteroid);
        }    
    }
}
