using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    //Jump Variables
    public Rigidbody2D rb;
    public BoxCollider2D boxCollider2D;
    public float buttonTime = 0.5f;
    public float jumpHeight = 5;
    public float cancelRate = 100;
    public float jumpForce;
    public float gravity;
    float jumpTime;
    bool jumping;
    bool jumpCancelled;

    public ContactFilter2D ContactFilter;

    //Raycast Ground Check
    public float distanceToCheck = 0.5f;
    public bool isGrounded => rb.IsTouching(ContactFilter);


    private void Update()
    {
        if (isGrounded)
        {
            jumpTime = 0;
        }


        if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 && (Input.touches[0].phase == TouchPhase.Began) && isGrounded && jumpTime == 0)
        {
            gravity = Physics2D.gravity.y * rb.gravityScale;
            jumpForce = Mathf.Sqrt(jumpHeight * - 2 * (gravity));
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumping = true;
            jumpCancelled = false;
        }
        if (jumping)
        {
            jumpTime += Time.deltaTime;
            if (Input.GetKeyUp(KeyCode.Space) || Input.touches[0].phase == TouchPhase.Ended)
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