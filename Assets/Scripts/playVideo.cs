using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playVideo : MonoBehaviour
{
	public GameObject video;
    // Start is called before the first frame update
    void Start()
    {
		video.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
	}

    public void playMedia()
	{
		video.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
	}
}
