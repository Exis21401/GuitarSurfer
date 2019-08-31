using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackSpawner : MonoBehaviour
{
	private float timeBetweenSpawns;
	public float startTimeBetweenSpawns;

	public GameObject myTrack;
	public Transform trackTransform;

    // Update is called once per frame
	void Start()
	{
	}
    void FixedUpdate()
    {
		if (timeBetweenSpawns <= 0) //if the delay between spawns reaches 0 we spawn new enemies
		{
			Instantiate(myTrack, trackTransform.position, trackTransform.rotation);
			timeBetweenSpawns = startTimeBetweenSpawns;
		}

		else
		{
			timeBetweenSpawns -= Time.deltaTime; //we decrease the time until it reaches 0 to spawn new enemies
		}
	}
}
