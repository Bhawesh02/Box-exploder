using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    private Rigidbody targetRb;
    private float maxSpeed = 15;
    private float minSpeed = 12;
    private float maxTorque = 10;
    private float xSpawn = 4;
    private float ySpawn = -2;



    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        // Move up
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        //Rotate target
        targetRb.AddTorque(RandomRotate(), RandomRotate(), RandomRotate(), ForceMode.Impulse);
        //Randow location
        transform.position = SpawnPos();
    }
    private void Update()
    {
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }


    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    float RandomRotate()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    Vector3 SpawnPos()
    {
        return new Vector3(Random.Range(-xSpawn, xSpawn), ySpawn, 0);
    }

}
