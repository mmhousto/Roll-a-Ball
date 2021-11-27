using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5;
    public float rotationSpeed = 20;

    private Rigidbody rb;

    private float horizontal;
    private float vertical;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(0, 0, vertical);
        //Vector3 rotation = new Vector3(0, horizontal, 0);

        rb.AddForce(transform.forward * vertical * speed);

        //cam.transform.RotateAround(transform.position, rotation, rotationSpeed);
        transform.Rotate(Vector3.up * horizontal * rotationSpeed);

        if (Input.GetKeyDown(KeyCode.E))
        {
            rb.AddExplosionForce(500f, transform.position, 20f);
        }
    }
}
