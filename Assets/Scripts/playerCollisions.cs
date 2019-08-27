using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollisions : MonoBehaviour
{
    public GameObject gameManager;
    public bool canDie;
    private bool Armor;
    public GameObject ArmorMesh;
    private GameObject Self;
	public GameObject pausePanel;
	public GameObject UI;
	public GameObject track_1;
	public GameObject track_2;
	public float trackSpeed_1;
	public float trackSpeed_2;
	// Start is called before the first frame update
	void Start()
    {
		pausePanel.SetActive(false);
		Self = this.gameObject;
        gameManager = GameObject.Find("gameManager");
		track_1 = GameObject.Find("H_SceneTrack");
		track_2 = GameObject.Find("H_Track");
		trackSpeed_1 = track_1.GetComponent<trackMovement>().trackSpeed;
		trackSpeed_2 = track_2.GetComponent<trackMovement>().trackSpeed;
		//movingTrack = GameObject.Find("H_Track");

	}

    // Update is called once per frame
    void Update()
    {
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Death" && canDie)
        {
            Destroy(this.gameObject);
			PauseGame();
            //gameManager.lives -= 1;
        }
        if (other.gameObject.tag == "Enemy" && !Armor) //if you dont have armor move down and speed down tracks
        {
            transform.Translate(0, 0, -4);
			trackSpeed_1 = 15;
			trackSpeed_2 = 15;
		}
        if (other.gameObject.tag == "Enemy" && Armor) //if you have armor destroy it
        {
            ArmorMesh.SetActive(false);
            Armor = false;
        }
        if (other.gameObject.tag == "SpeedP") // if you get speed power up, move forward and accelerate tracks
        {
            transform.Translate(0, 0, 4);
			trackSpeed_1 = 45;
			trackSpeed_2 = 45;
		}
        if (other.gameObject.tag == "ArmorP")
        {
            Armor = true;
            ArmorMesh.SetActive(true);
        }
    }
	private void PauseGame()
	{
		Time.timeScale = 0;
		HideUI();
		pausePanel.SetActive(true);
		//Disable scripts that still work while timescale is set to 0
	}
	private void HideUI()
	{
		UI.SetActive(false);
	}
}
