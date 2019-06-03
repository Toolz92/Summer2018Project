using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	public float playerHealth = 100.0f;
	public GameObject UIHandler;

	public void TakeDamage(int Damage){
		playerHealth -= Damage;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D collision){
		//Debug.Log ("Hit");
		//Debug.Log (collision.gameObject.name);
		if (collision.gameObject.tag == "EnemyBullet") {
			playerHealth -= collision.gameObject.GetComponent<ShotMovement> ().ShotDamage;
			Destroy (collision.gameObject);
			UIHandler.GetComponent<HealthUIHandler> ().RemoveHealthBlock ();
			if (playerHealth <= 0) {
				Destroy (gameObject);
			}
		}

	}
}
