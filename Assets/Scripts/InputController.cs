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

            //burada kendimiz kosulu veriyoruz, 20 olana kadar 1'er kez instantiate edecegiz.
            for (int i = 0; i < 20; i++)
            {
                asteroidList.Add(Instantiate(asteroidPrefabs, position, Quaternion.identity));
            }

            
      }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(asteroidList.Count);

            foreach(GameObject asteroid in asteroidList)
            {
                Destroy(asteroid);
            }

            asteroidList.Clear();

            // burada bilmiyoruz sayisini ve listeye biraktik hesap yapmayi. cunku kullanicinin kac kez sol tiklayip asteroid olusturdugunu bilmiyoruz. Sag tikladigimizda hepsini yok ediyor.
            //for(int i = 0; i< asteroidList.Count; i++)
            //{
            //    Destroy(asteroidList[i]);
            //}
        }
    }

   
}
