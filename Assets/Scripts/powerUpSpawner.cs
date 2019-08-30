using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpawner : MonoBehaviour
{
	private float timeBetweenSpawns;
	public float startTimeBetweenSpawns;

	public GameObject [] powerUps;
	public Transform [] spawnPoints;

    // Update is called once per frame
    void FixedUpdate()
    {
		if (timeBetweenSpawns <= 0) //if the delay between spawns reaches 0 we spawn new power ups
		{
			int randomNum = Random.Range(0, spawnPoints.Length);
			int randomNumber = Random.Range(0, powerUps.Length); //we select a random power up in the array
			Instantiate(powerUps[randomNumber], spawnPoints[randomNum].position, Quaternion.identity); //we spawn a random power up in the array		
			timeBetweenSpawns = startTimeBetweenSpawns; //restart the delay
		}
		else
		{
			timeBetweenSpawns -= Time.deltaTime; //we decrease the time until it reaches 0 to spawn new power ups
		}
	}
}
