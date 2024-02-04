using System;
// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Rigidbody2D rb;
    public float MaxSpeed;
    public float RotateSpeed;
    protected float CurrentRotate = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.MovePosition(transform.position + MaxSpeed * Time.fixedDeltaTime * Vector3.up);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            CurrentRotate += RotateSpeed;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            CurrentRotate -= RotateSpeed;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log(transform.forward);
        }

        rb.MoveRotation(CurrentRotate);
    }
}
