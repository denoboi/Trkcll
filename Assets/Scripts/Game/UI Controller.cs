using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    GameObject gameNameText = default;
    GameObject gameOverText = default;

    [SerializeField]
    Text pointsText = default;

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        pointsText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
