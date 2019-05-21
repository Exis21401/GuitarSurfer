using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackSpawner : MonoBehaviour
{
    public GameObject track;
    private Vector3 trackSpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        trackSpawnPos = new Vector3(0, 1, 18);

        SpawnTrack();

        Invoke("SpawnTrack", 0.6f);

        Invoke("SpawnTrack", 0.6f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTrack()
    {
        Instantiate(track, trackSpawnPos, transform.rotation);
    }
}
