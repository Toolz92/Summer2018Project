using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUIHandler : MonoBehaviour {
	public Image[] healthBlocks;
	private int playerHealth = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void RemoveHealthBlock()
	{
		playerHealth -= 1;
		healthBlocks [playerHealth].gameObject.SetActive (false);
		if (playerHealth <= 3) {
			for (int i = 0; i <= playerHealth; i++) {
				healthBlocks [i].color = Color.red;
			}
		} else if (playerHealth <= 7) {
			for (int i = 0; i <= playerHealth; i++) {
				healthBlocks [i].color = Color.yellow;
			}
		}

	}
}
