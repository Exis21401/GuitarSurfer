using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour
{
	public GameObject PausePanel;
	public GameObject UI;
	public bool isStartMenu;
   public void Restart()
	{
		PausePanel.SetActive(false);
		UI.SetActive(true);	
		Time.timeScale = 1;
		if (!isStartMenu)
		{
			SceneManager.LoadScene("Level_1");
		}
		
	}
		
}
