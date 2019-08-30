using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
	public GameObject UI;
	public bool showUI;
	public bool hideUI;
    // Start is called before the first frame update
    void Start()
    {
		show();
    }

    public void show()
	{
		if (showUI)
		{
			UI.SetActive(true);
		}
		else if (hideUI)
		{
			UI.SetActive(false);
		}
	}
	
}
