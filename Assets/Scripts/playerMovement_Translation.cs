using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement_Translation : MonoBehaviour
{
    public float speed;
    public bool moving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void AutoMove()
    {
        transform.Translate(Vector3.back * speed/2 * Time.deltaTime);
    }

    void Movement()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 position = transform.position;


        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && !moving && (position.x > -5))
        {
            transform.Translate(-4,0,0);
        }

        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && !moving && (position.x < 5))
        {
            transform.Translate(4,0,0);
        }

        if ((Input.GetKeyDown(KeyCode.A) | Input.GetKeyDown(KeyCode.D) | Input.GetKey(KeyCode.LeftArrow) == true))

		{
            moving = true;
        }
        if ((Input.GetKeyUp(KeyCode.A) | Input.GetKeyUp(KeyCode.D) | Input.GetKey(KeyCode.RightArrow) == true))

		{
            moving = false;
        }

    }

	public void MoveRight()
	{
		float moveHorizontal = Input.GetAxisRaw("Horizontal");
		float moveVertical = Input.GetAxisRaw("Vertical");
		Vector3 position = transform.position;

		if (!moving && (position.x < 5))
		{
			transform.Translate(4, 0, 0);
		}
	}
	public void MoveLeft()
	{
		float moveHorizontal = Input.GetAxisRaw("Horizontal");
		float moveVertical = Input.GetAxisRaw("Vertical");
		Vector3 position = transform.position;

		if (!moving && (position.x > -5))
		{
			transform.Translate(-4, 0, 0);
		}
	}
}
