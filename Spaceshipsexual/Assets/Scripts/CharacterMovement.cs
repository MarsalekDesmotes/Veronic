using UnityEngine;

public class CharacterMovement: MonoBehaviour
{
	public int speed;
	public int jumpSpeed;

	Animator animator;
	Rigidbody2D rb;

	bool canJump = true;
	bool faceRight = true;

	private void Start()
	{
		animator = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		float moveInput = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

		if (moveInput > 0 || moveInput < 0)
		{
			animator.SetBool("isRunning", true);
		}
		else
		{
			animator.SetBool("isRunning", false);
		}

		if (faceRight == true && moveInput < 0)
		{

			Flip();
		}
		else if (faceRight == false && moveInput > 0)
		{
			Flip();
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			Jump();
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.transform.tag == "Platform")
		{
			canJump = true;
		}
	}

	private void Jump()
	{
		if (canJump)
		{
			rb.AddForce(Vector2.up * jumpSpeed);
			canJump = false;
		}
	}

	private void Flip()
	{
		faceRight = !faceRight;
		Vector3 scaler = transform.localScale;
		scaler.x *= -1;
		transform.localScale = scaler;
	}

}
