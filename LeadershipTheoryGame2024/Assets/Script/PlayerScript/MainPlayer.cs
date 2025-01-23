using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameCore;
using UnityEngine.UI;

public class MainPlayer : MonoBehaviour
{
    // Option
    [SerializeField]
    GameObject option;

    // Moving
    float vertical, horizontal;
    public float MovingSpeed = 1;
    [SerializeField]private Transform ParentGo;

    

    // Animator
    Animator animator;

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.SetIsGame(true);
        // Animator
        animator = GetComponent<Animator>();

        // Rigidbody
        rb = GetComponent<Rigidbody2D>();
<<<<<<< HEAD
=======


>>>>>>> cb3efa79df9836acb2245610c26e1efe7545a44d
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.GetIsGame()) return;
        CheckMenu();
        Movement();
        UpdateAnimator();

    }


    private void FixedUpdate()
    {
        
    }



    // 他のキーのチェック
    void CheckMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.instance.SetIsGame(false);
            option.SetActive(true);
        }
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

    public string JiaoFu()
    {
        string childname="";
        foreach (Transform t in ParentGo)
        {
            childname = t.name;
            GameObject.Destroy(t.gameObject);
        }
        return childname;
    }
}
