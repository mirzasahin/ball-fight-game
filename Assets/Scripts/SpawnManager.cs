using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnPosX;
    private float spawnRangeX = 5;

    private float spawnPosZ;
    private float spawnRangeZ = 10;

    Vector3 RandomPos;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        spawnPosZ = Random.Range(-spawnRangeZ, spawnRangeZ);
        RandomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        InvokeRepeating("EnemySpawn", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnemySpawn()
    {
        Instantiate(enemyPrefab, RandomPos, enemyPrefab.transform.rotation);
    }
}
