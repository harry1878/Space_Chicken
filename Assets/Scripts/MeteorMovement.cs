using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    public float speed = 2f;

    private void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
}
