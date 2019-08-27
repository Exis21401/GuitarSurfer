using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRespawn : MonoBehaviour
{
	public GameObject enemy;
	public Transform spawnEnemy;
	public Transform track1;
	public Transform track2;
	public Transform track3;
	public Transform track4;
	public Transform track5;
	enum EnemyToSpawn { Random, Specific };
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
	private void onTriggerEnter(Collider other)
	{
		SpawnEnemy(EnemyToSpawn.Random);
	}
}
