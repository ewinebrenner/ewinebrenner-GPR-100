using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float groundCheckRadius = 0.2f;
    bool _grounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        _grounded = Physics2D.OverlapCircle(transform.position, groundCheckRadius);       
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _grounded ? Color.green : Color.red;
        Gizmos.DrawWireSphere(transform.position, groundCheckRadius);
    }
}
