using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Lives;
	public static float trackSpeed;
    public void LoadLevel(string NewLevel)
    {
        SceneManager.LoadScene(NewLevel);
    }

    private void Start()
    {
        Lives = 3;
		trackSpeed = 30;
    }

}
