using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BibleMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private Rigidbody rb;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate() 
    {
        rb.velocity = new Vector3(speed * horizontal, 0f, speed * vertical);
    }
}
