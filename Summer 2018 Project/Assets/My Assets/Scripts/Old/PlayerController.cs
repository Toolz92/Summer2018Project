using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public Camera MyCamera;
	[SyncVar(hook = "OnChangeColor")] 
	public Color myColor = new Color(1.0f,1.0f,1.0f);
	void Start(){
		NetworkManagerHUD hud = FindObjectOfType<NetworkManagerHUD>();
		if( hud != null )
			hud.showGUI = false;
		if (!isLocalPlayer)
		{
			MyCamera.enabled = false;
		}
	}

	// Update is called once per frame
	void Update () {

		if (!isLocalPlayer)
		{
			MyCamera.enabled = false;
			return;
		}

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			CmdFire();
		}
	}

	public override void OnStartLocalPlayer()
	{
		myColor = Random.ColorHSV (0f, 1f, 1f, 1f, 0.5f, 1f);
		GetComponent<Renderer>().material.color = myColor;
	}

	public void OnChangeColor(Color value){
		//myColor = Color.blue;
		GetComponent<Renderer>().material.color = myColor;
	}
	[Command]
	void CmdFire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate (
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

		// Spawn the bullet on the Clients
		NetworkServer.Spawn(bullet);

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 2.0f);
	}
}
