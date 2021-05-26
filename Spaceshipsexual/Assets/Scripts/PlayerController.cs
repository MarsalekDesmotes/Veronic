using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    //Movement
  
    public Rigidbody2D rb;
    public float speed;
    public float jump;
    float moveVelocity;

    //Grounded Vars
    bool grounded = true;



    private void Start()
    {
        rb.GetComponent<Rigidbody2D>();
       
    }

    void Update()
    {
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            if (grounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jump);
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);

    }
    //Check if Grounded
    void OnTriggerEnter2D()
    {
        grounded = true;
    }
    void OnTriggerExit2D()
    {
        grounded = false;
    }
}