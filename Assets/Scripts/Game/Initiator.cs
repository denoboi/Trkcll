using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initiator : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        ScreenCalculator.Init();
    }
}
