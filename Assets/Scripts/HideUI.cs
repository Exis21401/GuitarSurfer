using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideUI : MonoBehaviour
{
	public GameObject UI;
	public bool hideUI;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void show()
	{
		if (hideUI)
		{
			UI.SetActive(false);
		}
	}
	
}
