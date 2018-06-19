using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	float speed;
	Vector3 Moving;
	bool CanMove;

	CharacterController PlayerController;

	int Rotation;

	public FinishedScreen EndScreen;
	public DiedScreen DeathScreen;

	public TurnScreen Turning;

	void Start () {
		speed = 0.2f;
		Rotation = 0;
		CanMove = true;
		PlayerController = GetComponent<CharacterController> ();
		Turning = GameObject.Find ("Main Camera").gameObject.GetComponent<TurnScreen> ();
	}

	void Update () {
		if (CanMove) {
						if (Input.GetKeyDown (KeyCode.W)) {
								EndScreen.LevelStarted ();
								MoveUp ();
						}
						if (Input.GetKeyDown (KeyCode.A)) {
								EndScreen.LevelStarted ();
								MoveLeft ();
						}
						if (Input.GetKeyDown (KeyCode.S)) {
								EndScreen.LevelStarted ();
								MoveDown ();
						}
						if (Input.GetKeyDown (KeyCode.D)) {
								EndScreen.LevelStarted ();
								MoveRight ();
						}
				}
		if (Input.GetKeyDown (KeyCode.R)) 
			{
			Application.LoadLevel(Application.loadedLevel);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) 
			{
			Application.LoadLevel("MainMenu");
		}

		PlayerController.Move (Moving);
	
	}

	void MoveLeft()
	{
		switch (Rotation) 
		{
		case 0:
			Moving.x = -speed;
			break;
		case 1:
			Moving.y = -speed;
			break;
		case 2:
			Moving.x = speed;
			break;
		case 3:
			Moving.y = speed;
			break;

		}
	}

	void MoveRight()
	{
		switch (Rotation) 
		{
		case 0:
			Moving.x = speed;
			break;
		case 1:
			Moving.y = speed;
			break;
		case 2:
			Moving.x = -speed;
			break;
		case 3:
			Moving.y = -speed;
			break;
			
		}
	}

	void MoveUp()
	{
		switch (Rotation) 
		{
		case 0:
			Moving.y = speed;
			break;
		case 1:
			Moving.x = -speed;
			break;
		case 2:
			Moving.y = -speed;
			break;
		case 3:
			Moving.x = speed;
			break;	
		}
	}

	void MoveDown()
	{
		switch (Rotation) 
		{
		case 0:
			Moving.y = -speed;
			break;
		case 1:
			Moving.x = speed;
			break;
		case 2:
			Moving.y = speed;
			break;
		case 3:
			Moving.x = -speed;
			break;	

		}
	}

	void OnTriggerEnter(Collider Other)
	{
		if (Other.tag == "Wall") 
		{
			//GameOver;
			BlockStuff();
			System.Threading.Thread.Sleep(500);
			DeathScreen.Died();
		}

		if (Other.tag == "Finish")
		{
			//GameDone;
			EndScreen.LevelFinished();
			ResetSpeed();
			BlockStuff();
		}

		if (Other.tag == "Obstacle") 
		{
			//GameOver;
			BlockStuff();
			System.Threading.Thread.Sleep(500);
			DeathScreen.Died();
		}
	}
	
	public void Rotate(float Side)
	{
		if(Side == 0)
		{
			Rotation ++;
			if(Rotation == 4)
				Rotation = 0;
		}
		else if (Side == 1)
		{
			Rotation --;
			if(Rotation == -1)
				Rotation = 3;
		}
		ResetSpeed ();
	}

	void ResetSpeed()
	{
		Moving = Vector3.zero;
	}

	void BlockStuff()
	{
		ResetSpeed ();
		CanMove = false;
		Turning.LockMovement ();
	}
}
