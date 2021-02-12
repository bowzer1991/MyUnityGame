using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;

    public float horizontal;
    public float vertical;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Move();
    }

    private void Move()
    {
        // Move Forward
        Vector3 move = new Vector3(horizontal, 0.0f, vertical);
        transform.Translate(move * speed * Time.deltaTime);

        // Rotate

        // Move Backwards

        // Strafe Left

        // Strafe Right
    }
}
