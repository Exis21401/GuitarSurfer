using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollisions : MonoBehaviour
{
    public GameManager gameManager;
    public bool canDie;
    private bool Armor;
    public GameObject ArmorMesh;
    private GameObject Self;
    // Start is called before the first frame update
    void Start()
    {
        Self = this.gameObject;
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
            SceneManager.LoadScene("Level_1");
        }
        if (other.gameObject.tag == "Enemy" && !Armor)
        {
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
