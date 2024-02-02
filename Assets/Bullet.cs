using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public Quaternion firstRotation;
    public float speedY = 10;

    void Start()
    {
        firstRotation = transform.rotation;
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        Vector3 movementSpeed = new Vector3(0, speedY, 0);

        movementSpeed = firstRotation * movementSpeed;

        rigidbody.AddForce(movementSpeed);
        Destroy(gameObject,3.0f);
    }

    void Update()
    {


    }
}