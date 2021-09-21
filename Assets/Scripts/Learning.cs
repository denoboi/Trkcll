using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        int attackingEnemy = 10;
        bool attackContinues = false;

        //while (attackContinues)
        //{
        //    attackingEnemy--;
        //    if (attackingEnemy < 3)
        //    {
        //        attackContinues = false;
        //    }
        //    Debug.Log("saldiran dusman sayisi: " + attackingEnemy);
        //}

        do
        {
            attackingEnemy--;
            if (attackingEnemy < 3)
            {
                attackContinues = false;
            }
            Debug.Log("saldiran dusman sayisi: " + attackingEnemy);
        }
        while (attackContinues);
       
    }

       

    // Update is called once per frame
    void Update()
    {
        
    }
}
