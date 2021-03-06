using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float jumpHeight;
	public float moveSpeed;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	private bool doubleJumped;

	public Transform firePoint;
	public GameObject fireBall;

	// Use this for initialization
	void Start () {
	}

	void FixedUpdate(){
		
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

	}
	
	// Update is called once per frame
	void Update () {

		if (grounded)
			doubleJumped = false;

		if (Input.GetKeyDown (KeyCode.Space) && grounded) 
		{
			Jump();
		}

		if (Input.GetKeyDown (KeyCode.Space) && !doubleJumped && !grounded) 
		{
			Jump();
			doubleJumped = true;

		}

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

		if (Input.GetKeyDown (KeyCode.F)) 
		{
			Instantiate(fireBall, firePoint.position, firePoint.rotation);
		}
			
	}


	public void Jump()
	{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
	}
}
