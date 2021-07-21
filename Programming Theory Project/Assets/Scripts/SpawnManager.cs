using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] enemiesPrefab;
    private float yRange = 13.0f;
    private float xSpawnPos = 38.0f;
    private float zSpawnPos = -2.0f;

    private int startDelay = 2;
    private int repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GameOverCheck", startDelay, repeatRate);
    }

    void GameOverCheck()
    {
        if (!MainManager.isGameOver)
        {
            SpawnRandomEnemy();
        }
    }

    void SpawnRandomEnemy()
    {
        int randomIndex = Random.Range(0, enemiesPrefab.Length);
        float ySpawnPos = Random.Range(-yRange, yRange);
        Vector3 spawnPos = new Vector3(xSpawnPos, ySpawnPos, zSpawnPos);

        Instantiate(enemiesPrefab[randomIndex], spawnPos, enemiesPrefab[randomIndex].transform.rotation);
    }
}
