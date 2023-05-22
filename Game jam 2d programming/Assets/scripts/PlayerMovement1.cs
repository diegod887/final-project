using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD:Game jam 2d programming/Assets/scripts/playermovement.cs
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jump;

    private float move;
    private Rigidbody2D rb;
    private bool isJumping;
    
=======
public class PlayerMovement1 : MonoBehaviour
{
    public float movespeed;
    public float jumpforce;
    private Rigidbody2D rb;
    public bool faceright = true;
    private float moveDirection;
    private bool isJumping = false;
    private bool isgrounded = false;

>>>>>>> origin/Diego:Game jam 2d programming/Assets/scripts/PlayerMovement1.cs
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isgrounded = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:Game jam 2d programming/Assets/scripts/playermovement.cs
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && !isJumping)
=======
        moveDirection = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
>>>>>>> origin/Diego:Game jam 2d programming/Assets/scripts/PlayerMovement1.cs
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
        }
<<<<<<< HEAD:Game jam 2d programming/Assets/scripts/playermovement.cs
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
=======
        if (moveDirection > 0 && !faceright)
        {
            flipcharacter();
        }
        else if (moveDirection < 0 && faceright)
        {
            flipcharacter();
        }
        //rb.velocity = new Vector2(moveDirection * movespeed, rb.velocity.y);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection * movespeed, rb.velocity.y);
        if (isJumping == true)
        {
            if (isgrounded == true)
            {
                rb.AddForce(new Vector2(10f, jumpforce));
            }
            isgrounded = false;
        }
        isJumping = false;
    }
    private void flipcharacter()
    {
        faceright = !faceright;
        transform.Rotate(0f, 180f, 0f);
    }

>>>>>>> origin/Diego:Game jam 2d programming/Assets/scripts/PlayerMovement1.cs

}

