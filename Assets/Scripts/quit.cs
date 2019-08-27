using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit : MonoBehaviour
{
	public GameObject PausePanel;
	public void QuitGame()
	{
		PausePanel.SetActive(false);
		Application.Quit();
	}
}
