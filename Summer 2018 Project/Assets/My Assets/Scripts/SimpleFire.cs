using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFire : MonoBehaviour {
	public Rigidbody2D Bullet;
	public float Speed;
	private float nextFire;
	public float fireRate;

	void Fire(){
		Rigidbody2D bullet = (Rigidbody2D)Instantiate (Bullet, transform.position, transform.rotation);
		bullet.velocity = transform.forward * Speed;

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && (Time.time > nextFire)) {
				nextFire = Time.time + fireRate;
				Fire ();
		}
	}
}
