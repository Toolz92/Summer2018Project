using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {
	public Vector3 startPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Constant down movement
		var z = -1 * Time.deltaTime * 3.0f;
		transform.Translate(z, 0, 0);
		//Position reset
		if (transform.position.y < -10.0f) {
			//Debug.Log ("Titties");
			transform.position = startPoint;
		}
	}
}
