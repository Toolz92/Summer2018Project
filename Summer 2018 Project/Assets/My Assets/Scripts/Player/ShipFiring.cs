using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFiring : MonoBehaviour {
	public Rigidbody2D Shot1;
	public Rigidbody2D Shot2;
	public Rigidbody2D Shot3;
	public Rigidbody2D Shot4;
	private Rigidbody2D mainTemp;
	private Rigidbody2D secondTemp;
	public float Speed;
	private float nextFire;
	public float fireRate;
	public bool isFiring = false;
	public int FireLevel = 1;
	public GameObject leftCannon;
	public GameObject rightCannon;

	void mainFire(Rigidbody2D bullet){
		Rigidbody2D Shot = (Rigidbody2D)Instantiate (bullet, transform.position, transform.rotation);

	}
	void SecondaryFire(Rigidbody2D bullet){
		Rigidbody2D Shot2 = (Rigidbody2D)Instantiate (bullet, leftCannon.transform.position, leftCannon.transform.rotation);
		Rigidbody2D Shot3 = (Rigidbody2D)Instantiate (bullet, rightCannon.transform.position, rightCannon.transform.rotation);
	}
	public void AddFireLevel(){
		FireLevel++;
		if (FireLevel == 2) {
			mainTemp = Shot2;
		} else if (FireLevel == 3) {
			mainTemp = Shot3;
		} else if (FireLevel == 4) {
			mainTemp = Shot4;
		} else if (FireLevel == 6) {
			secondTemp = Shot2;
		} else if (FireLevel == 7) {
			secondTemp = Shot3;
		} else if (FireLevel == 8) {
			secondTemp = Shot4;
		}
	}

	// Use this for initialization
	void Start () {
		mainTemp = Shot1;
		secondTemp = Shot1;
	}

	// Update is called once per frame
	void Update () {
		GetKeyDown ();
		GetKeyUp ();
		if (isFiring && (Time.time > nextFire)) {
			nextFire = Time.time + fireRate;

			mainFire(mainTemp);
			if (FireLevel > 4) {
				SecondaryFire (secondTemp);
			}
		}
	}

	void GetKeyDown(){
		if (Input.GetKeyDown(KeyCode.Space)) {
			isFiring = true;
		}
		if (Input.GetKeyDown(KeyCode.R)) {
			AddFireLevel ();
		}
	}
	void GetKeyUp(){
		if (Input.GetKeyUp(KeyCode.Space)) {
			isFiring = false;

		}
	}
}
