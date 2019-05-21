using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private Vector3 enemySpawnPos;
    public Transform track1;
    public Transform track2;
    public Transform track3;
    public Transform track4;
    public Transform track5;
    public Transform spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        SpawnWave(1);
    }
    private void Update()
    {

    }

    void SpawnEnemy()
    {
        Instantiate(enemy, spawnPosition.position, Quaternion.identity);
    }
    void SpawnWave(int wave)
    {
        if (wave == 1)
        {
            Wave1();
        }
    }

    void Wave1()
    {
        //spawnPosition = track2;
        SpawnEnemy();
    }
}
