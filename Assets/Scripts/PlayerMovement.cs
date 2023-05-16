using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float moveSpeed;
    private float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        jumpForce = 20;
        isJumping = false;
        moveSpeed = .1f;
    }

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        if (moveHorizontal > 0f || moveHorizontal < 0f)
        {
            rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f),ForceMode2D.Impulse);
        }

        if (!isJumping && moveVertical > 0f)
        {
            rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }
    }
    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
    }
    void OnTriggerExit2D(Collider2D Collision)
    {
        if (Collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }
}
