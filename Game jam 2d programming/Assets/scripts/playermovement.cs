using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float movespeed;
    public float jumpForce;
    public Rigidbody2D rb;
    public bool faceright = true;
    private float moveDirection;
    private bool isJumping = false;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");
        if (Input.GetButton("Jump"))
        {
            isJumping = true;
        }
        if (moveDirection > 0 && !faceright)
        {
            flipcharacter();
        }
        else if (moveDirection < 0 && faceright)
        {
            flipcharacter();
        }
        
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection * movespeed, rb.velocity.y);
        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
        isJumping = false;
    }
    private void flipcharacter()
    {
        faceright = !faceright;
        transform.Rotate(0f, 180f, 0f);
    }

    private void ProcessInputs()
    {

    }
    IEnumerator PowerUpSpeed()
    {
        movespeed = 9;
        yield return new WaitForSeconds(5);
        movespeed = 5;
    }

    public void SpeedPowerUp()
    {
        StartCoroutine(PowerUpSpeed());
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "MovingPlatform")
        {
            transform.parent = col.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }
}
