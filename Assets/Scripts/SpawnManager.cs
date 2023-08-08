using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnRangeX = 5;
    private float spawnRangeZ = 10;

    private float startDelay = 1f;
    private float spawnInterval = 2f;
    public int enemyCount;
    Enemy[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(3);
        //InvokeRepeating("EnemySpawn", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        enemies = FindObjectsOfType<Enemy>();
        enemyCount = enemies.Length;
        if(enemyCount == 0)
        {
            SpawnEnemyWave(1);
        }
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);  
        }
    }

    //private void EnemySpawn()
    //{
    //    Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    //}

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        float spawnPosZ = Random.Range(-spawnRangeZ, spawnRangeZ);
        Vector3 RandomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return RandomPos;
    }
}
