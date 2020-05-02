using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundModule : MonoBehaviour
{
    public float Speed = 1f;
    private float offset = -0.33f;
    private Material material = null;

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        if (offset > 0.2f) offset = 0f;
        offset += Speed * Time.deltaTime;
        material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
