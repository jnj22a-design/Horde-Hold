using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float jumpForce = 500.0f;
    private float moveDirection;
    Rigidbody2D rb;
    public bool isGrounded = false;
    public bool shouldJump = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveDirection = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            shouldJump = true;
        }
    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveDirection * moveSpeed, rb.linearVelocity.y);

        if (shouldJump == true)
        {
            shouldJump = false;
            rb.AddForce(transform.up * jumpForce);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        isGrounded = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        isGrounded = false;
    }

}
