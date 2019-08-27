using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackMovement : MonoBehaviour
{
	private float speed;
	private GameObject track;
    //public float trackSpeed;
    // Start is called before the first frame update
    void Start()
    {
		track = gameObject;
		speed = track.GetComponent<GameManager.trackSpeed>();
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.name == "H_Track_End")
        {
            //Destroy(this.gameObject);
            transform.position = new Vector3(0, 1, 18);
        }
    }
}
