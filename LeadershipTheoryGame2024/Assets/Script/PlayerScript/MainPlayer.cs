using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    // Moving
    float vertical, horizontal;
    public float MovingSpeed = 1;

    // Animator
    Animator animator;

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        // Animator
        animator = GetComponent<Animator>();

        // Rigidbody
        rb = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        UpdateAnimator();

    }


    private void FixedUpdate()
    {
        
    }



    // Player Movement
    void Movement()
    {
        // Moving Assignment
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 input = new Vector2(horizontal, vertical).normalized;
        // Moving Code
        rb.linearVelocity = input * 15 * MovingSpeed;
    }



    // Player Animator
    void UpdateAnimator()
    {
        Vector2 pVelocity = rb.linearVelocity;
        float pVelocityX = pVelocity.x;
        float pVelocityY = pVelocity.y;
        if (pVelocityX < 0) animator.SetBool("MovingLeft", true);
        if (pVelocityX > 0) animator.SetBool("MovingLeft", false);
        if (pVelocityY < 0) animator.SetBool("MovingDown", true);
        if (pVelocityY > 0) animator.SetBool("MovingDown", false);
        if(pVelocity == Vector2.zero) 
            animator.SetBool("IsMoving", false );
        else
            animator.SetBool("IsMoving", true);

    }
}
