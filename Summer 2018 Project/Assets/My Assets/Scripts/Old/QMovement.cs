using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QMovement : MonoBehaviour {
	public GameObject QUpRight;
	public GameObject QUpLeft;
	public GameObject QDownRight;
	public GameObject QDownLeft;

	public GameObject StartPoint;
	public GameObject handler;
	public GameObject Coily;

	public AudioSource Jump;
	public AudioSource Spinner;
	public AudioSource GreenBallGet;
	public AudioSource DeathSound;
	public GameObject swear;
	// Use this for initialization
//	void Start () {
//		Time.timeScale = 1;
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		GetInput ();
//	}
//	void OnTriggerEnter(Collider collision){
//		//print ("WHY THO");
//		if (collision.gameObject.tag == "MovePoint") {
//			QUpLeft = collision.gameObject.GetComponent<PointMoveScript>().UpLeft;
//			QUpRight = collision.gameObject.GetComponent<PointMoveScript>().UpRight;
//			QDownLeft = collision.gameObject.GetComponent<PointMoveScript>().DownLeft;
//			QDownRight = collision.gameObject.GetComponent<PointMoveScript>().DownRight;
//		}
//		if (collision.gameObject.tag == "Spinner") {
//			
//			transform.position = StartPoint.transform.position;
//			transform.rotation = Quaternion.Euler(0, 0, 0);
//			Destroy (collision.gameObject);
//			if (Coily.GetComponent<CoilyBehaviorScript> ().direction.magnitude <= 3) {
//				Destroy (Coily);
//				handler.GetComponent<ScoreHandler> ().AddScore (500);
//				Spinner.Play ();
//			}
//		}
//		if (collision.gameObject.tag == "GreenBall") {
//			//print ("WHY THO");
//			Destroy (collision.gameObject);
//			handler.GetComponent<ScoreHandler> ().AddScore (100);
//			GreenBallGet.Play ();
//			Coily.GetComponent<CoilyBehaviorScript> ().enabled = false;
//			Invoke ("freeCoily",5.0f);
//		}
//		if (collision.gameObject.tag == "RedBall") {
//			//print ("WHY THO");
//			Destroy (collision.gameObject);
//			handler.GetComponent<LivesHandler> ().LoseLife();
//			DeathSound.Play ();
//			swear.gameObject.SetActive(true);
//			Invoke ("switchSwear",2.0f);
//		}
//		if (collision.gameObject.tag == "Coily") {
//			//print ("WHY THO");
//			Destroy (collision.gameObject);
//			handler.GetComponent<LivesHandler> ().LoseLife();
//			handler.GetComponent<BallSpawning> ().isCoilyAlive = false;
//			DeathSound.Play ();
//			swear.gameObject.SetActive(true);
//			Invoke ("switchSwear",2.0f);
//		}
//		if (collision.gameObject.tag == "Death") {
//			//print ("WHY THO");
//			transform.position = StartPoint.transform.position;
//			transform.rotation = Quaternion.Euler(0, 0, 0);
//			handler.GetComponent<LivesHandler> ().LoseLife();
//			DeathSound.Play ();
//			swear.gameObject.SetActive(true);
//			Invoke ("switchSwear",2.0f);
//
//		}
//	}
//	void GetInput(){
//		if (Input.GetKeyUp("[3]")) {
//			this.transform.position = QDownRight.transform.position;
//			transform.rotation = Quaternion.Euler(0, 0, 0);
//			Jump.Play ();
//
//		}
//		if (Input.GetKeyUp("[1]")) {
//			this.transform.position = QDownLeft.transform.position;
//			transform.rotation = Quaternion.Euler(0, 90, 0);
//			Jump.Play ();
//		}
//		if (Input.GetKeyUp("[7]")) {
//			this.transform.position = QUpLeft.transform.position;
//			transform.rotation = Quaternion.Euler(0, 180, 0);
//			Jump.Play ();
//		}
//		if (Input.GetKeyUp("[9]")) {
//			this.transform.position = QUpRight.transform.position;
//			transform.rotation = Quaternion.Euler(0, 270, 0);
//			Jump.Play ();
//		}
//	}
//	void switchSwear(){
//		swear.SetActive (false);
//	}
//	void freeCoily(){
//		Coily.GetComponent<CoilyBehaviorScript> ().enabled = true;
//		print ("Coily is free");
//	}
}
