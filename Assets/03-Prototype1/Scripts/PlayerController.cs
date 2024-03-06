using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement);
        rb.AddForce(movement * speed);
       // if (Mathf.Abs(movementX) < 0.01f && Mathf.Abs(movementY) < 0.01f)
       // {
      //      rb.velocity = Vector3.zero;
       // }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            if (other.gameObject.CompareTag("Coins"))
            {
                other.gameObject.SetActive(false);
            }
        }
        other.gameObject.SetActive(false);

    }
}
