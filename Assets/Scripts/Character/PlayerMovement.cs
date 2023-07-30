using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{

    //Jump Variables
    public Rigidbody2D rb;
    public Animator animator;
    public BoxCollider2D boxCollider2D;
    public float buttonTime = 0.5f;
    public float jumpHeight = 5;
    public float cancelRate = 100;
    public float jumpForce;
    public float gravity;

    private float rbCheckerY;
    private float counter;

    private bool hitCroc = false;
    float jumpTime;
    bool jumping;
    bool jumpCancelled;

    public ContactFilter2D ContactFilter;

    public bool isGrounded => rb.IsTouching(ContactFilter);

    private void Update()
    {
        //if (hitCroc)
        //{
        //    animator.Play("Capybara on croc animation");
        //}

        if ((Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 && (Input.touches[0].phase == TouchPhase.Began)) && isGrounded)
        {
            gravity = Physics2D.gravity.y * rb.gravityScale;
            jumpForce = Mathf.Sqrt(jumpHeight * -2 * (gravity));
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumping = true;
            jumpCancelled = false;
            jumpTime = 0;
            animator.Play("Capybara jump animation");
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

        if (rb.velocity.y < 0)
        {
            animator.Play("Capybara fall animation");
        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Ground")
        {
            animator.Play("Capybara_walk_animation");
        }

        //if (collision.transform.tag == "Croc" && hitCroc != false)
        //{
        //    hitCroc = true;
        //}
    }

    private void FixedUpdate()
    {
        if (jumpCancelled && jumping && rb.velocity.y > 0)
        {
            rb.AddForce(Vector2.down * cancelRate);
        }
    }


}