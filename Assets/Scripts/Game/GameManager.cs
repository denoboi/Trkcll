using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject spaceShipPrefab;
    GameObject spaceShip;

    void Start()
    {
        spaceShip = Instantiate(spaceShipPrefab);
        spaceShip.transform.position = new Vector3(0, ScreenCalculator.Asagi + 1.5f);
    }

    
    void Update()
    {
        
    }
}
