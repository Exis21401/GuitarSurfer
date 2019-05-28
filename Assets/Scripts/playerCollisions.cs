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
    // Start is called before the first frame update
    void Start()
    {
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
            Armor = false;
        }
        if (other.gameObject.tag == "SpeedP")
        {
            transform.Translate(0, 0, 4);
        }
        if (other.gameObject.tag == "ArmorP")
        {
            Armor = true;
            Instantiate(ArmorMesh);
            ArmorMesh.transform.SetParent(this.transform);
        }
    }
}
