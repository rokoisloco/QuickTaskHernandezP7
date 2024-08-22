using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Pool;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 15;
    public float jumpForce = 15;
   

    private Rigidbody rb;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(horizontalInput * moveSpeed, rb.velocity.y, rb.velocity.z);

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            Jump();
        }

         void Jump()
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(new Vector2(5f, jumpForce), ForceMode.Impulse);
        }
    }
}
