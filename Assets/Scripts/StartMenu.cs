using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
	public GameObject startMenuPanel;
	public GameObject UI;
	// Start is called before the first frame update
	void Start()
    {
		PauseGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void PauseGame()
	{
		Time.timeScale = 0;
		UI.SetActive(false);
		startMenuPanel.SetActive(true);
		//Disable scripts that still work while timescale is set to 0
	}
}
