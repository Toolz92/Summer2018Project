using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour {
	public Rigidbody2D Body;
	public float JumpHeight;
	public float MoveSpeed;
	private bool IsMovingLeft = false;
	private bool IsMovingRight = false;
	public SpriteRenderer sprite;
	public bool isflying = false;
	public Animator test;
	public AnimatorControllerParameter temp;
	public Animation rest;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetKeyDown ();	
		GetKeyUp ();
		FlyCheck ();
		Move();
	}
	void FlyCheck(){
		if (this.transform.position.y > -2.4f) {
			isflying = true;
		} else {
			isflying = false;

		}
	}
	void GetKeyDown(){
		if (Input.GetKeyDown(KeyCode.W)) {
			Body.AddForce(transform.up * JumpHeight);
			//print("Up");

		}
		else if (Input.GetKeyDown("a")) {
			IsMovingLeft = true;
			//Body.velocity = transform.right * MoveSpeed;
			//transform.rotation = Quaternion.Euler(0, 180, 0);
			sprite.flipX = true;
		}
		else if (Input.GetKeyDown("s")) {
			
			//print ("Down");
		}
		else if (Input.GetKeyDown("d")) {
			IsMovingRight = true;
			sprite.flipX = false;
		}
	}
	void GetKeyUp(){
		if (Input.GetKeyUp("a")) {
			IsMovingLeft = false;
			//Body.velocity = transform.right * MoveSpeed;

		}
		else if (Input.GetKeyUp("s")) {

			//print ("Down");
		}
		else if (Input.GetKeyUp("d")) {
			IsMovingRight = false;
		}
	}

	void Move (){
		if (IsMovingLeft) {
			//Body.velocity = transform.right * MoveSpeed * -1;
			Body.AddForce (transform.right * MoveSpeed * -1);
			//this.gameObject.transform.position.x = MoveSpeed * Time.deltaTime;
		}
		if (IsMovingRight) {
			//Body.velocity = transform.right * MoveSpeed;
			Body.AddForce (transform.right * MoveSpeed);
		}
	}
}
