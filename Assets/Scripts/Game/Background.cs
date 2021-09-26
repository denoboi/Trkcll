using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    MeshRenderer meshRenderer;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //material y degerinin offsetini zaman gectikce artacak sekilde degistiriyoruz
        float y = 0.1f * Time.time;

        meshRenderer.material.SetTextureOffset("_MainTex", new Vector2(0, y));
    }
}
