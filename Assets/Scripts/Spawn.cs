using UnityEngine;

public class Spawn : MonoBehaviour
{
    public static int level = 1;

    private bool stop = false;
    private float time;
    private float endTime;
    

    [SerializeField] private Transform[] spawners;
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject end;
    [SerializeField] private float timeToSpawn = 2f;
    [SerializeField] private float wave = 1f;
    [SerializeField] private int baseTime;
    
    void Start()
    {
        time = Time.time;
        endTime = time + (baseTime * Level.currentLevel);
    }
    
    void Update()
    {
        if (!stop)
        {
            if (Time.time > endTime)
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
