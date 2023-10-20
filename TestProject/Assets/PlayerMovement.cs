using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalSpeed = 5.0f;
    public float verticalSpeed = 5.0f;
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(xInput * horizontalSpeed, yInput * verticalSpeed);
       // rb.AddForce(new Vector2(xInput * horizontalSpeed, yInput * verticalSpeed));
    }
}
