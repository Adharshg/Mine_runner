using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour {

	public CharacterController2D controller;
	public float jumpSpeed = 700f;
	public float runSpeed = 400f;
	public Animator animator;
	private float horizontalMove = 0f;
	//private bool isjump = false;
	private float jumpPressedRemTime = 0.1f;
	private float groundedRemTime = 0.1f;
	private float jumpPressedRem;
	private bool isGrounded;
	private float groundedRem;
	private Rigidbody2D rigid;
	private bool facingRight = true;


	void Start(){
		isGrounded = false;
		rigid = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		
		horizontalMove = Input.GetAxisRaw("Horizontal2") * runSpeed;
		Flip(horizontalMove);
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		jumpPressedRem -= Time.deltaTime;
		groundedRem -= Time.deltaTime;

		if (Input.GetButtonDown("Jump2")){
			jumpPressedRem =  jumpPressedRemTime;
			//isjump = true;
		}

		if (isGrounded){
			groundedRem = groundedRemTime;

		}

	}

	void FixedUpdate() {
		
		//jump stuff
		if((jumpPressedRem > 0) && (groundedRem > 0)){
			//jumpPressedRem = 0;
			groundedRem = 0;
			rigid.velocity = new Vector2(rigid.velocity.x, jumpSpeed * Time.deltaTime);
			//controller.Move(horizontalMove * Time.fixedDeltaTime, false, isjump);
			//isjump = false;
		}


		//movementstuff
		rigid.velocity = new Vector2(horizontalMove * runSpeed * Time.deltaTime, rigid.velocity.y);
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.CompareTag("Ground")){
			isGrounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D other){
		if(other.gameObject.CompareTag("Ground")){
			isGrounded = false;

		}
	}

	void Flip(float horizontalMove){
		if ((horizontalMove > 0 && !facingRight) || (horizontalMove < 0 && facingRight)){
			facingRight = !facingRight;

			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}
}
