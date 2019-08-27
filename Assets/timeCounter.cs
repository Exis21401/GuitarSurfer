using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeCounter : MonoBehaviour
{
	public float GameTimer;
	public GameObject UITime;
	private Text UIText;
    // Start is called before the first frame update
    void Start()
    {
		//UIText = UITime.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
		GameTimer += Time.deltaTime;
		UIText.text = UIText.text + GameTimer.ToString();
	}
}
