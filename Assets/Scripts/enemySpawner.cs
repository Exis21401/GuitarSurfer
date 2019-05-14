using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private Vector3 enemySpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        spawnWave(1);
    }

    void spawnWave(int wave)
    {
        if (wave == 1)
        {
            Wave1();
        }

        if (wave == 2)
        {
            Wave1();
        }

        if (wave == 3)
        {
            Wave1();
        }

        if (wave == 4)
        {
            Wave1();
        }
    }

    void Wave1()
    {
        enemySpawnPos = new Vector3(-8, 2.1f, 18);
        Instantiate(enemy, enemySpawnPos, transform.rotation);
        enemySpawnPos = new Vector3(-4, 2.1f, 18);
        Instantiate(enemy, enemySpawnPos, transform.rotation);
        enemySpawnPos = new Vector3(0, 2.1f, 18);
        Instantiate(enemy, enemySpawnPos, transform.rotation);
    }
}
