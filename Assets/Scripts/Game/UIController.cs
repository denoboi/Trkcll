using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    GameObject gameNameText;

    [SerializeField]
    GameObject gameOverText;

    [SerializeField]
    Text pointsText = default;

    [SerializeField]
    GameObject playButton = default;

    int points;

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        pointsText.gameObject.SetActive(false);
    }

    public void GameStarted()
    {
        gameNameText.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
        pointsText.gameObject.SetActive(true);
        UpdateScore();
    }

    public void UpdateScore()
    {
        pointsText.text = "Score: " + points;
        
    }

    /// <summary>
    /// Asteroidleri yok ettikce score artacak
    /// </summary>
    public void AsteroidDestroyed(GameObject asteroid) // hangi tur oyun objesi yok ettigimizi belirtmek icin parametre gonderiyoruz
    {
        switch(asteroid.gameObject.name[8])
        {
            case '1':
                points += 1;
                UpdateScore();
                break;

            case '2':
                points += 2;
                UpdateScore();
                break;
            case '3':
                points += 5;
                UpdateScore();
                break;
        }  
            
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
