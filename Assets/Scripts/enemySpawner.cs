using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
	private float timeBetweenSpawns;
	public float startTimeBetweenSpawns;

	public GameObject[] Enemies;
	private GameObject patternSpawned;

    // Update is called once per frame
    void FixedUpdate()
    {
		if (timeBetweenSpawns <= 0) //if the delay between spawns reaches 0 we spawn new enemies
		{
			int randomNumber = Random.Range(0, Enemies.Length); //we select a random pattern in the array
			if (patternSpawned != null)
			{
				Destroy(patternSpawned);
			}
			else
			{ 
				patternSpawned = Instantiate(Enemies[randomNumber], transform.position, Quaternion.identity); //we spawn a random pattern in the array
			}
			
			timeBetweenSpawns = startTimeBetweenSpawns; //restart the delay
		}
		else
		{
			timeBetweenSpawns -= Time.deltaTime; //we decrease the time until it reaches 0 to spawn new enemies
		}
	}
}
