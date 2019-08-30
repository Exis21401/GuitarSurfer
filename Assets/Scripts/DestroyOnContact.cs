using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
	public bool isHTrackEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

		if (isHTrackEnd && other.gameObject.tag != "HTrack")
		{
			Destroy(other.gameObject);
		}
		else
		{
			Destroy(this.gameObject);
		}
        
    }
}
