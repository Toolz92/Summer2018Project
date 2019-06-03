using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MemeMode : MonoBehaviour {
	public GameObject videoplayer;
	public GameObject ScoreHandler;
	// Use this for initialization
	void Start () {
		//Time.timeScale = 2;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("p")) {
			MemeModeActivate ();
		}
	}
	public void MemeModeActivate(){
		Time.timeScale = 2;
		ScoreHandler.GetComponent<ScoreHandleScript> ().memeModeActivate ();
		videoplayer.GetComponent<VideoPlayer> ().Play ();
	}
}
