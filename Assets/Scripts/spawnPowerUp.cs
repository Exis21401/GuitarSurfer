using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPowerUp : MonoBehaviour
{
	public GameObject powerUp;
    // Start is called before the first frame update
    void Start()
    {
		Instantiate(powerUp, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
