using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public GameObject enemy;
    public float rotationSpeed;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RotateEnemy();
        MoveEnemy();   
    }

    void RotateEnemy()
    {
        transform.Rotate(0, rotationSpeed, 0);

    }

    void MoveEnemy()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);
    }
}
