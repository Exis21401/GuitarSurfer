using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchInput : MonoBehaviour
{
	private GameObject player;
	private bool moving;
	private Touch touch;
	// Start is called before the first frame update
	void Start()
    {
		player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
			//if (touch.phase == TouchPhase.Began){moving = true;}			
			//if (touch.phase == TouchPhase.Ended) { moving = false; }
	}

	public void MoveRight()
	{
		if (player.transform.position.x < 5)
		{
			player.transform.Translate(4, 0, 0);
		}
	}
	public void MoveLeft()
	{
		if (player.transform.position.x > -5)
		{
			player.transform.Translate(-4, 0, 0);
		}
	}
}


