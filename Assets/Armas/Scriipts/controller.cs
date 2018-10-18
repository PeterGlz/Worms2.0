using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
	public float topSpeed = 10f;
	public float jumpForce;
	private float moveInput;

	private Rigidbody2D rb;

	private bool facingRight = true;
    private bool canMove;

	private bool isGrounded;
	public Transform groundedCheck;
	public float checkRadius;
	public LayerMask whatisGrounded;

	private int extraJumps;
	public int extraJumpsValue;

	void Start()
	{
        canMove = true;
		extraJumps = extraJumpsValue;
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate()
	{
		isGrounded = Physics2D.OverlapCircle (groundedCheck.position,checkRadius, whatisGrounded);

        if (Input.GetMouseButton(0) || canMove == false)
            topSpeed = 0f;
        else
        {
            topSpeed = 10f;
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * topSpeed, rb.velocity.y);
        }  

		if (facingRight == false && moveInput > 0) {
			Flip ();
		} else if (facingRight == true && moveInput < 0) {
			Flip ();
		}
	}

	void Update()
	{
		if (isGrounded == true) {
			extraJumps = extraJumpsValue;
		}
		
		if (Input.GetKeyDown (KeyCode.Space) && extraJumps > 0) {
			rb.velocity = Vector2.up * jumpForce;
			extraJumps--;
		} else if (Input.GetKeyDown (KeyCode.Space) && extraJumps == 0 && isGrounded == true) {
			rb.velocity = Vector2.up * jumpForce;
		}

        ClickM();
	}

    private void ClickM()
    {
        if(Input.GetMouseButtonDown(0))
        {
            canMove = false;
            StartCoroutine(Congelar());
        }
    }

    IEnumerator Congelar()
    {
        yield return new WaitForSeconds(1);
        canMove = true;
    }

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;
	}
}
