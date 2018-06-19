using UnityEngine;
using System.Collections;

public class TurnScreen : MonoBehaviour {

	public Movement PlayerMovement;

	bool CanMove;
	float CurrentRotation;
	float InitRot;

	GameObject Player;
	float PlayerX;
	float PlayerY;

	void Start () 
	{
		CanMove = true;
		CurrentRotation = 0;
		InitRot = 0;

		Player = GameObject.FindGameObjectWithTag("Player");
		PlayerX = 0;
		PlayerY = 0;

		//PlayerMovement = Player.GetComponent<Movement> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (CanMove) 
		{
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				RotateLeft ();
			}
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				RotateRight ();
			}
		}
	}
		
	void RotateRight()
	{
		LockMovement ();
		CurrentRotation = transform.eulerAngles.z;
		InitRot = 0f;
		while (InitRot < 90) {
			InitRot += 10 * Time.deltaTime;
			transform.eulerAngles = new Vector3(0, 0,CurrentRotation + InitRot);
		}
		transform.eulerAngles = new Vector3(0,0, Mathf.Round (CurrentRotation + 90));
		SetPlayerPosition (0);
		UnLockMovement ();
	}

	void RotateLeft()
	{
		LockMovement ();
		CurrentRotation = transform.eulerAngles.z;
		InitRot = 0f;
		while (InitRot < 90) {
			InitRot += 10 * Time.deltaTime;
			transform.eulerAngles = new Vector3(0, 0,CurrentRotation - InitRot);
		}
		transform.eulerAngles = new Vector3(0,0, Mathf.Round (CurrentRotation - 90));
		UnLockMovement ();
		SetPlayerPosition (1);
	}

	public void LockMovement()
	{
		CanMove = false;
	}

	void UnLockMovement()
	{
		CanMove = true;
	}

	void SetPlayerPosition (int Rotation)
	{
		PlayerX = Player.transform.position.x;
		PlayerY = Player.transform.position.y;
		switch (Rotation) 
		{
		case 0:
			PlayerMovement.Rotate(0);
			Player.transform.position = new Vector3(-PlayerY, PlayerX, -0.1f);
			break;
		case 1:
			PlayerMovement.Rotate(1);
			Player.transform.position = new Vector3(PlayerY, -PlayerX, -0.1f);
			break;
		}
	}	
}
