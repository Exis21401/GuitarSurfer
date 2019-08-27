using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollisions : MonoBehaviour
{
    public GameObject gameManager;
	private GameObject movingTrack;
    public bool canDie;
    private bool Armor;
    public GameObject ArmorMesh;
    private GameObject Self;
    // Start is called before the first frame update
    void Start()
    {
        Self = this.gameObject;
        gameManager = GameObject.Find("gameManager");
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
            //gameManager.lives -= 1;
            SceneManager.LoadScene("Level_1");
        }
        if (other.gameObject.tag == "Enemy" && !Armor)
        {
			//movingTrack.trackMovement.trackSpeed = trackSpeed / 2;
            transform.Translate(0, 0, -4);
        }
        if (other.gameObject.tag == "Enemy" && Armor)
        {
            ArmorMesh.SetActive(false);
            Armor = false;
        }
        if (other.gameObject.tag == "SpeedP")
        {
            transform.Translate(0, 0, 4);
        }
        if (other.gameObject.tag == "ArmorP")
        {
            Armor = true;
            ArmorMesh.SetActive(true);
        }
    }
}
