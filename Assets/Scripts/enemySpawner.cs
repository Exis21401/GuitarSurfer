﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
	public GameObject enemy;
	public GameObject speedUp;
	public GameObject Armor;
	private Vector3 enemySpawnPos;
	public Transform track1;
	public Transform track2;
	public Transform track3;
	public Transform track4;
	public Transform track5;
	public Transform spawnEnemy;
	public Transform spawnPowerUp;
	public Transform spawnArmor;
	enum EnemyToSpawn {Random,Specific};
	// Start is called before the first frame update
	void Start()
	{
		SpawnWave(1);
		SpawnSpeedP();
		SpawnArmorP();
	}
	private void Update()
	{

	}

	

    void SpawnEnemy(EnemyToSpawn MyEnemy)
    {
		if (MyEnemy == EnemyToSpawn.Specific)
		{
			Instantiate(enemy, spawnEnemy.position, Quaternion.identity);
		}
		else if (MyEnemy == EnemyToSpawn.Random)
		{
			int trackPosition = Random.Range(1, 5);
			switch (trackPosition)
			{
				case 1:
					spawnEnemy = track1;
					break;
				case 2:
					spawnEnemy = track2;
					break;
				case 3:
					spawnEnemy = track3;
					break;
				case 4:
					spawnEnemy = track4;
					break;
				case 5:
					spawnEnemy = track5;
					break;
			}
			Instantiate(enemy, spawnEnemy.position, Quaternion.identity);
		}

        
    }

    void SpawnSpeedP()
    {
        Instantiate(speedUp, spawnPowerUp.position, Quaternion.identity);
    }
    void SpawnArmorP()
    {
        Instantiate(Armor, spawnArmor.position, Quaternion.identity);
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
        SpawnEnemy(EnemyToSpawn.Random);
    }

	private void onTriggerEnter(Collider other)
	{
		SpawnEnemy(EnemyToSpawn.Random);
	}
}
