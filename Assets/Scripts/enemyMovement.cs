using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public GameObject enemy;
    public float rotationSpeed;
    public float moveSpeed;
    private int[] tracks;
    public int newTrack;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 40;
        tracks = new int[] {-8, -4, 0, 4, 8};
        transform.position = new Vector3(newTrack, 2.1f, 18);
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "H_Track_End")
        {
            newTrack = Random.Range(0, tracks.Length);
            Debug.Log("New track: " + newTrack);
            newTrack = tracks[newTrack];
            transform.position = new Vector3(newTrack, 2.1f, 18);
            Instantiate(enemy, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
