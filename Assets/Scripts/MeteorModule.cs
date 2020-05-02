using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorModule : MonoBehaviour
{
    public float speed = 5f;
    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
    }
}
