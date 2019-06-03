using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {
	Animator animator;
	private bool left = false;
	private bool right = false;
	public GameObject MainCannon;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;
		//bool left = Input.GetKeyDown (KeyCode.A);
		//bool right = Input.GetKeyDown(KeyCode.D);
		//transform.Rotate(0, x, 0);
		GetKeyDown();
		GetKeyUp ();
		animator.SetBool("IsLeft",left);
		animator.SetBool("IsRight", right);
		transform.Translate(x, z, 0);
		//transform.Translate (x, 0, 0);
		animator.SetBool("IsLeft",left);
		animator.SetBool("IsRight", right);
		if (Input.GetKeyDown (KeyCode.Escape)) {
			#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
			#else
			Application.Quit();
			#endif
		}
	}

	void GetKeyDown(){
		if (Input.GetKeyDown("a")) {
			left = true;
		}
		else if (Input.GetKeyDown("d")) {
			right = true;
		}
	}
	void GetKeyUp(){
		if (Input.GetKeyUp("a")) {
			left = false;

		}
		else if (Input.GetKeyUp("d")) {
			right = false;
		}
	}
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Pickup") {
			Destroy (collision.gameObject);
			MainCannon.GetComponent<ShipFiring> ().AddFireLevel ();
		}
	}
}
