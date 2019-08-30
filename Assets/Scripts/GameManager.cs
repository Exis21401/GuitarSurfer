using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Lives;
	public GameObject player;
	public string timeDisplay;
	public static float trackSpeed;
    public void LoadLevel(string NewLevel)
    {
        SceneManager.LoadScene(NewLevel);
    }

    private void Start()
    {
		Time.timeScale = 1;
        Lives = 3;
		trackSpeed = 30;
    }

	private void Update()
	{
	}

}
