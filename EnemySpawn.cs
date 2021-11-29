using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    private float SpawnInterval;
    public float InitialSpawnInterval;
    public float MinimumSpawnInterval;
    public float SpawnTimeReduction;

    void Update()
    {
        if(SpawnInterval<=0.5)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            SpawnInterval = InitialSpawnInterval;
            if(InitialSpawnInterval > MinimumSpawnInterval)
            {
                InitialSpawnInterval -= SpawnTimeReduction;
            }
        }
        else
        {
            SpawnInterval -= Time.deltaTime;
        }
    }
}
