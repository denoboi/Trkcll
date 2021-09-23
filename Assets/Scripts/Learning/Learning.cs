using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
  

    void Start()
    {
        //constructor 2. olan aslinda
        SpaceShip ship1 = new SpaceShip(Random.Range(80, 100), "Red");
        SpaceShip ship2 = new SpaceShip(Random.Range(80, 100));

        if (ship1.MaxSpeed > ship2.MaxSpeed)
        {
            Debug.Log("ship1 victorious");
        }
        else if (ship2.MaxSpeed > ship1.MaxSpeed)
        {
            Debug.Log("Ship2 victorious");
        }
        else
            Debug.Log("DRAW");

        //int attackingEnemy = 10;
        //bool attackContinues = false;

        //while (attackContinues)
        //{
        //    attackingEnemy--;
        //    if (attackingEnemy < 3)
        //    {
        //        attackContinues = false;
        //    }
        //    Debug.Log("saldiran dusman sayisi: " + attackingEnemy);
        //}

        //do
        //{
        //    attackingEnemy--;
        //    if (attackingEnemy < 3)
        //    {
        //        attackContinues = false;
        //    }
        //    Debug.Log("saldiran dusman sayisi: " + attackingEnemy);
        //}
        //while (attackContinues);

    }

       

    // Update is called once per frame
    void Update()
    {
        
    }
}
