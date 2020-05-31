using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronauta : MonoBehaviour
{
    //public Joystick joystick;
    [SerializeField] private float runSpeed = 10.0f;
    private float horizontalMove = 0f, verticalMove = 0f;
    private Rigidbody2D rb;
    private Animator animation;
    private SpriteRenderer render;
    private bool colidindo = false;
    private EspacoController controller;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
        controller = FindObjectOfType<EspacoController>();
    }

    void Update()
    {
        //horizontalMove = joystick.Horizontal * runSpeed;
        //verticalMove = joystick.Vertical * runSpeed;
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        verticalMove = Input.GetAxis("Vertical") * runSpeed;

        rb.velocity = new Vector2(horizontalMove, verticalMove);

        if (horizontalMove > 0 || horizontalMove < 0)
        {
            animation.SetBool("Moving", true);
        }
        else
        {
            animation.SetBool("Moving", false);
        }

        if (horizontalMove > 0)
        {
            render.flipX = true;
        }
        else if (horizontalMove < 0)
        {
            render.flipX = false;
        }

        if (Input.GetKey(KeyCode.DownArrow) && colidindo)
        {
            controller.abrePainel();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Chao")
        {
            animation.SetBool("Grounded", true);
        }
        else
        {
            animation.SetBool("Grounded", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        animation.SetBool("Grounded", false); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Maca")
        {
            colidindo = true;
            Debug.Log("Maca");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Maca")
        {
            colidindo = false;
            Debug.Log("Nao Maca");
        }
    }
}
