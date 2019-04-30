using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    #region VARIABLES
    public float speed;
    public float maxSpeed;
    public float acceleration;
    public float deceleration;
    float right;
    float forward;
    Rigidbody rb;
    Vector3 vel;
    #endregion

    #region START AND UPDATE
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        rb.velocity = vel;
        Movement();
        Accelerate();
    }
    #endregion

    #region MOVEMENT AND ACCELERATION
    void Movement() {

        if (Input.GetKey(KeyCode.W)){
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
        }
        if (Input.GetKey(KeyCode.A)){
            rb.velocity = new Vector3(-speed, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKey(KeyCode.S)){
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -speed);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
        }

     }

    void Accelerate(){
        forward = Input.GetAxis("Forward");
        right = Input.GetAxis("Right");

        if(forward != 0 || right != 0)
        {
            speed += acceleration * Time.deltaTime;
            speed = Mathf.Clamp(speed, 0, maxSpeed);
        }
        else
        {
            speed -= deceleration * Time.deltaTime;
            speed = Mathf.Clamp(speed, 0, maxSpeed);
        }

        /*if(Input.GetAxisRaw("Right") != 0){
            vel.x = acceleration * right * Time.deltaTime;
        }

        else if(Input.GetAxisRaw("Right") == 0){
            vel.x = deceleration * right * Time.deltaTime;
        }

        if (Input.GetAxisRaw("Forward") != 0)
        {
            vel.z = acceleration * forward * Time.deltaTime;
        }

        else if (Input.GetAxisRaw("Forward") == 0)
        {
            vel.z = deceleration * forward * Time.deltaTime;
        }

        vel.x = Mathf.Clamp(vel.x, -speed, speed);
        vel.z = Mathf.Clamp(vel.z, -speed, speed);*/
    }
    #endregion

}
