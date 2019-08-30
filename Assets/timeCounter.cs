using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeCounter : MonoBehaviour
{
	public float gameTimer;
	public GameObject UITime;
	public string myText;
	private Text UIText;
	// Start is called before the first frame update
	void Start()
    {
		UIText = UITime.GetComponent<Text>();
    }

	// Update is called once per frame
	void Update()
	{
		/*if (gameTimer >= 10)
		{
			gameTimer = 0;
		}*/
		gameTimer += Time.deltaTime;
		myText = Mathf.RoundToInt(gameTimer).ToString();
		if (Mathf.RoundToInt(gameTimer) < 10)
		{
			UIText.text = "Time: 0" + myText;
		}
		else
		{
			UIText.text = "Time: " + myText;
		}
		
	}
}
