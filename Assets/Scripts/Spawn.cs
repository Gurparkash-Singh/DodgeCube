using UnityEngine;

public class Spawn : MonoBehaviour
{

    public Transform[] spawners;
    public GameObject enemy;
    public GameObject end;
    public float timeToSpawn = 2f;
    public float wave = 1f;
    private bool stop = false;
    
    void Update()
    {
        if (!stop)
        {
            if ((Time.time >= 8))
            {
                stop = true;
                Instantiate(end, spawners[0].position, Quaternion.identity);
            }
            else if (Time.time >= timeToSpawn)
            {
                spawnBlock();
                timeToSpawn = Time.time + wave;
            }
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
