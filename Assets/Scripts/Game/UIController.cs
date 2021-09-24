using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    GameObject gameNameText = default;

    [SerializeField]
    GameObject gameOverText = default;

    [SerializeField]
    Text pointsText = default;

    [SerializeField]
    GameObject playButton = default;

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        pointsText.gameObject.SetActive(false);
    }

    public void GameStarted()
    {
        gameNameText.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
