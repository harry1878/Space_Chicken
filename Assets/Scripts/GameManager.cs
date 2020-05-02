using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefab_S = null;
    public GameObject prefab_B = null;

    public float S_waitTime = 1f;
    public float B_waitTime = 10f;
    public float S_createTime = 1f;
    public float B_createTime = 15f;
    private float range = 3;
    public int quantity = 3;

    private void Start()
    {
        S_waitTime = Time.time + S_createTime;
        B_waitTime = Time.time + B_createTime;

    }

    private void Update()
    {
        if(Time.time >= S_waitTime)
        {
            Create_S_Meteor();
            S_waitTime = Time.time + S_createTime;
        }
        if (Time.time >= B_waitTime)
        {
            Create_B_Meteor();
            B_waitTime = Time.time + B_createTime;
        }
    }

    public void Create_S_Meteor()
    {
        for (int i = 0; i < quantity; ++i)
        {
            var meteor = Instantiate(prefab_S, transform);
            meteor.transform.position = new Vector3(
                Random.Range(-range, range), 7.2f, 0);
        }
    }
    public void Create_B_Meteor()
    {
        for (int i = 0; i < 1; ++i)
        {
            var meteor = Instantiate(prefab_B, transform);
            meteor.transform.position = new Vector3(
                Random.Range(-range, range), 7.2f, 0);
        }
    }
}