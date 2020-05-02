using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModule : MonoBehaviour
{
    public float Speed = 10f;
    public Rigidbody2D rigid = null;

    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, Speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -Speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }
    }
}
