using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public Joystick joystick;
    [SerializeField] private float runSpeed = 10.0f;
    private float horizontalMove = 0f, verticalMove = 0f;
    private Rigidbody2D rb;
    private Animator animation;
    private SpriteRenderer render;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //horizontalMove = joystick.Horizontal * runSpeed;
        //verticalMove = joystick.Vertical * runSpeed;
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        verticalMove = Input.GetAxis("Vertical") * runSpeed;

        rb.velocity = new Vector2(horizontalMove, verticalMove);

        if (horizontalMove > 0.2 || horizontalMove < -0.2){
            animation.SetBool("Vertical", true);
        }else{
            animation.SetBool("Vertical", false);
        }

        if (horizontalMove > 0)
        {
            render.flipX = false;
        }else if (horizontalMove < 0)
        {
            render.flipX = true;
        }
    }
}
