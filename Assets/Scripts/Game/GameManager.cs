using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject spaceShipPrefab;
    GameObject spaceShip;

    [SerializeField]
    List<GameObject> asteroidPrefabs = new List<GameObject>();

    List<GameObject> asteroidList = new List<GameObject>();

    [SerializeField]
    int difficulty = 1;

    [SerializeField]
    int difficultyMultiplier = 2;


    void Start()
    {
        spaceShip = Instantiate(spaceShipPrefab);
        spaceShip.transform.position = new Vector3(0, ScreenCalculator.Asagi + 1.5f);
        SpawnAsteroid(5);
    }

    
    void Update()
    {
        
    }

    void SpawnAsteroid(int count)
    {
        Vector3 position = new Vector3();

        for (int i = 0; i < count; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x = (Random.Range(ScreenCalculator.Sol, ScreenCalculator.Sag));
            position.y = (ScreenCalculator.Yukari - 1);

            //prefab'den var edilen asteroid sayisini ogrenmek icin asteroid degiskeni ekledim
            GameObject asteroid = Instantiate(asteroidPrefabs[Random.Range(0,3)], position, Quaternion.identity);

            //Simdi de onlari yukarida ikinci olusturdugum listeye ekleyecegim ki yok olmamis asteroidlerin tam sayisini ogreneyim
            asteroidList.Add(asteroid);
        }
    }

    public void AsteroidDestroyed(GameObject asteroid)
    {
        asteroidList.Remove(asteroid);
        if(asteroidList.Count <= difficulty)
        {
            difficulty++;
            SpawnAsteroid(difficulty * difficultyMultiplier);
        }

    }
}
