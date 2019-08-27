using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour
{
	public GameObject PausePanel;
	public GameObject UI;
   public void Restart()
	{
		PausePanel.SetActive(false);
		if (!UI)
		{
			UI.SetActive(true);
		}	
		Time.timeScale = 1;
		SceneManager.LoadScene("Level_1");
	}
		
}
