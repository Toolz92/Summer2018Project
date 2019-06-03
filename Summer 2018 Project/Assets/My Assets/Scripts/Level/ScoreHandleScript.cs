using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandleScript : MonoBehaviour {
	public Text ScoreText;
	private int Score = 0;
	private int scoreIncrement = 1;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		IncrementScore (scoreIncrement);
	}
	public void IncrementScore(int Addition){
		//Debug.Log ("Nipples");
		ScoreText.text = " " + (Score + Addition);
		Score += Addition;
	}
	public void memeModeActivate(){
		scoreIncrement = 69;
	}
}
