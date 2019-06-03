using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovement : MonoBehaviour {
	public float ShotSpeed = 3.0f;
	public float Life = 3.0f;
	public float ShotDamage = 1.0f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, Life);
	}
	
	// Update is called once per frame
	void Update () {
		var z = 1 * Time.deltaTime * ShotSpeed;
		transform.Translate(0, z, 0);
	}

}
