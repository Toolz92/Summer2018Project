using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {
	public GameObject leftCannon;
	public GameObject rightCannon;
	public Rigidbody2D bullet;
	public bool hasArrived = false;
	public float stopPoint = 4.0f;
	private float nextFire;
	public float fireRate;
	public float health = 10;
	public GameObject Handler;
	public Rigidbody2D BulletPickup;
	void MoveDown(){
		//Constant down movement
		var z = -1 * Time.deltaTime * 3.0f;
		transform.Translate(0, -z, 0);
		//Position reset
		if (transform.position.y < 4.0f) {
			//Debug.Log ("Titties");
			hasArrived = true;
		}
	}
	void Fire (){
		Rigidbody2D Shot2 = (Rigidbody2D)Instantiate (bullet, leftCannon.transform.position, leftCannon.transform.rotation);
		Rigidbody2D Shot3 = (Rigidbody2D)Instantiate (bullet, rightCannon.transform.position, rightCannon.transform.rotation);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasArrived) {
			MoveDown ();
		} else {
			if (Time.time > nextFire) {
				nextFire = Time.time + fireRate;
				Fire ();
			}
		}
	}
	void OnCollisionEnter2D(Collision2D collision){
		//Debug.Log ("Hit");
		//Debug.Log (collision.gameObject.name);
		if (collision.gameObject.tag == "PlayerBullet") {
			health -= collision.gameObject.GetComponent<ShotMovement> ().ShotDamage;
			Destroy (collision.gameObject);
		}
		if (health <= 0) {
			//Handler.GetComponent<ScoreHandleScript> ().IncrementScore (1000);
			Rigidbody2D Drop = (Rigidbody2D)Instantiate(BulletPickup,this.transform.position, BulletPickup.transform.rotation);
			Destroy (gameObject);
		}
	}
}
