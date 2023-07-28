using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VariableJump : MonoBehaviour
{
    public float runSpeed;
    public Rigidbody2D rb;
    public BoxCollider2D boxCollider2D;
    public float buttonTime = 0.5f;
    public float jumpHeight = 5;
    public float cancelRate = 100;
    float jumpTime;
    bool jumping;
    bool jumpCancelled;

    public ContactFilter2D ContactFilter;

    //Raycast Ground Check
    public float distanceToCheck = 0.5f;
    public bool isGrounded => rb.IsTouching(ContactFilter);


    private void Update()
    {

       rb.velocity = new Vector2 (1 * runSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            float jumpForce = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * rb.gravityScale));
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumping = true;
            jumpCancelled = false;
            jumpTime = 0;
        }
        if (jumping)
        {
            jumpTime += Time.deltaTime;
            if (Input.GetKeyUp(KeyCode.Space))
            {
                jumpCancelled = true;
            }
            if (jumpTime > buttonTime)
            {
                jumping = false;
            }
        }
    }
    private void FixedUpdate()
    {
        if (jumpCancelled && jumping && rb.velocity.y > 0)
        {
            rb.AddForce(Vector2.down * cancelRate);
        }
    }


}