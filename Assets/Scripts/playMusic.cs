using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusic : MonoBehaviour
{
	public GameObject myMusic;
	public AudioSource myAudio;
	public bool play;
	public bool stop;
    // Start is called before the first frame update
    void Start()
    {
		myAudio = myMusic.GetComponent<AudioSource>();
		if (play && !myAudio.isPlaying)
		{
			myAudio.Play();
		}
		else if(stop && myAudio.isPlaying)
		{
			myAudio.Stop();
		}
		
	}

	public void PlayMusic()
	{
		if (!myAudio.isPlaying)
		{
			myAudio.Play();
		}
	}

	public void StopMusic()
	{
		if (myAudio.isPlaying)
		{
			myAudio.Stop();
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
