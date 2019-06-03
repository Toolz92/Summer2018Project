using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour {
	public float Life = 0.0f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, Life);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
