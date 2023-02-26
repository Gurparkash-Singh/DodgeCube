using UnityEngine;

public class Spawn : MonoBehaviour
{

    public Transform[] spawners;
    public GameObject enemy;
    public GameObject end;
    public float timeToSpawn = 2f;
    public float wave = 1f;
    
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            spawnBlock();
            timeToSpawn = Time.time + wave;
        }
    }

    void spawnBlock()
    {
        int skip = Random.Range(0, spawners.Length);
        for (int i = 0; i < spawners.Length; i++)
        {
            if (skip != i)
            {
                Instantiate(enemy, spawners[i].position, Quaternion.identity);
            }
        }
    }
}
