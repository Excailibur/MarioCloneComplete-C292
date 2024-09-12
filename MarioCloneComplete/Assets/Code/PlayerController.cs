using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float runSpeed = 5.0f;
    [SerializeField] private float jumpForce = 5.0f;

    [SerializeField] private Vector2 direction;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // Used for input
    void Update()
    {
        Move();
        Jump();
    }

    private void Jump()
    {
        //if (Input.GetButtonDown("Jump"))
        //{
        //    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    private void Move()
    {
        float move = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * move * runSpeed * Time.deltaTime);

        //Vector2 moveDir = Vector2.zero;
        //if (Input.GetKey(KeyCode.A))
        //{
        //    moveDir = Vector2.left;
        //}
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    moveDir = Vector2.right;
        //}
        //else
        //{
        //    moveDir = Vector2.zero;
        //}

        //rb.velocity = new Vector2(moveDir.x * runSpeed, rb.velocity.y);
    }
}
