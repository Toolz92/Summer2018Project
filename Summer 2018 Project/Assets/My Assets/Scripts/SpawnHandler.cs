using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour {
	public Vector3[] waves;
	public GameObject SpawnLeft;
	public GameObject SpawnMid;
	public GameObject SpawnRight;
	public Rigidbody2D[] enemies;
	private float nextSpawn;
	public float SpawnRate;
	private int counter;
	// Use this for initialization
	void Start () {
		Invoke ("SpawnWaveOne",1);
		Invoke ("SpawnWaveTwo", 11);
		Invoke ("SpawnWaveThree", 23);
		InvokeRepeating ("SpawnRandom", 25, 1);
	}
	
	// Update is called once per frame
	void Update () {
//		if (Time.time > nextSpawn) {
//			nextSpawn = Time.time + SpawnRate;
//			//Spawn (SpawnLeft,enemies[0]);
//		}
//		for (int i = 0; i < 5; i++) {
//			if (waves [i].y == 1) {
//				//Invoke ("Spawn (SpawnLeft,enemies[0])", 1);
//				Spawn (SpawnMid,enemies[0]);
//
//			}
//
//		}

	}

	void Spawn(GameObject spawnPoint, Rigidbody2D enemy){
		Rigidbody2D Enemy = (Rigidbody2D)Instantiate (enemy, spawnPoint.transform.position, spawnPoint.transform.rotation);
	}

	void SpawnWaveOne(){
		Rigidbody2D EnemyLeft = (Rigidbody2D)Instantiate (enemies[0], SpawnLeft.transform.position, SpawnLeft.transform.rotation);
		Rigidbody2D EnemyMid = (Rigidbody2D)Instantiate (enemies[0], SpawnMid.transform.position, SpawnMid.transform.rotation);
		Rigidbody2D EnemyRight = (Rigidbody2D)Instantiate (enemies[0], SpawnRight.transform.position, SpawnRight.transform.rotation);

	}
	void SpawnWaveTwo(){
		Rigidbody2D EnemyLeft = (Rigidbody2D)Instantiate (enemies[0], SpawnLeft.transform.position, SpawnLeft.transform.rotation);
		//Rigidbody2D EnemyMid = (Rigidbody2D)Instantiate (enemies[0], SpawnMid.transform.position, SpawnMid.transform.rotation);
		Rigidbody2D EnemyRight = (Rigidbody2D)Instantiate (enemies[0], SpawnRight.transform.position, SpawnRight.transform.rotation);
	}
	void SpawnWaveThree(){
		Rigidbody2D EnemyLeft = (Rigidbody2D)Instantiate (enemies[0], SpawnLeft.transform.position, SpawnLeft.transform.rotation);
		Rigidbody2D EnemyMid = (Rigidbody2D)Instantiate (enemies[0], SpawnMid.transform.position, SpawnMid.transform.rotation);
		//Rigidbody2D EnemyRight = (Rigidbody2D)Instantiate (enemies[0], SpawnRight.transform.position, SpawnRight.transform.rotation);
	}
	void SpawnRandom(){
		if (Random.Range (1, 3) == 1) {
			Rigidbody2D EnemyLeft = (Rigidbody2D)Instantiate (enemies[0], SpawnLeft.transform.position, SpawnLeft.transform.rotation);
		}
		if (Random.Range (1, 3) == 1) {
			Rigidbody2D EnemyMid = (Rigidbody2D)Instantiate (enemies[0], SpawnMid.transform.position, SpawnMid.transform.rotation);
		}
		if (Random.Range (1, 3) == 1) {
			Rigidbody2D EnemyRight = (Rigidbody2D)Instantiate (enemies[0], SpawnRight.transform.position, SpawnRight.transform.rotation);
		}
	}
}
