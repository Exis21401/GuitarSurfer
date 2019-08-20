using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Lives;
    public void LoadLevel()
    {
        SceneManager.LoadScene("ProbuilderTest");
    }

    private void Start()
    {
        Lives = 3;
    }

}
