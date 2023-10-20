using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalSpeed = 5.0f;
    public float verticalSpeed = 5.0f;
    public Score score;

    Rigidbody2D _rb;
    float _xInput;
    float _yInput;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _xInput = Input.GetAxisRaw("Horizontal");
        _yInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_xInput * horizontalSpeed, _yInput * verticalSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit something");
        score.score += 10;
        collision.transform.position = new Vector3(
                Random.Range(-4.0f, 4.0f), //X
                Random.Range(-1.7f, 1.7f), //Y
                0); //Z
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
