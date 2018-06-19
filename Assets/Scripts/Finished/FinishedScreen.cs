using UnityEngine;
using System.Collections;

public class FinishedScreen : MonoBehaviour {
	float LevelTimer;

	bool Finished;
	bool Started;

	float ButtonWidth;
	float ButtonHeigth;

	GameObject EndScreen;
	GameObject MainCamer;

	public MoveClouds MoveThese;

	void Start () {
		LevelTimer = 0;
		Finished = false;
		Started = false;

		ButtonWidth = Screen.width / 10;
		ButtonHeigth = Screen.height / 10;

		EndScreen = GameObject.FindGameObjectWithTag ("EndScreen");
		MainCamer = GameObject.FindGameObjectWithTag ("MainCamera");

		GUI.color = Color.black;
	}

	void OnGUI () {
		if (Finished) 
		{
			if(GUI.Button( new Rect( ButtonWidth * 2, (Screen.height / 2 + Screen.height / 7 - 10) - 15, ButtonWidth + 30, ButtonHeigth), "Main Menu"))
			{
				Application.LoadLevel("MainMenu");
			}
			if(GUI.Button( new Rect( ButtonWidth * 4, (Screen.height / 2 + Screen.height / 7 - 10) - 15, ButtonWidth + 30, ButtonHeigth), "Retry"))
			{
				Application.LoadLevel(Application.loadedLevel);
			}
			if(GUI.Button( new Rect( ButtonWidth * 6, (Screen.height / 2 + Screen.height / 7 - 10) - 15, ButtonWidth + 30, ButtonHeigth), "Next Level"))
			{
				int i = Application.loadedLevel;
				Application.LoadLevel(i + 1);
			}
			GUI.Label(new Rect( ( Screen.width / 2 ) - 150, (Screen.height / 2 + Screen.height / 4), 200, 20), "Level Finished in : " + Mathf.Round(LevelTimer * 100f)/100f + " sec");
		}
	}

	void Update()
	{
		if (!Finished && Started) 
		{
			LevelTimer += Time.deltaTime;
		}

		if (Finished) 
		{
			if(Input.GetKeyDown(KeyCode.Return))
			   {
				int i = Application.loadedLevel;
				Application.LoadLevel(i + 1);

				}
		}
	}

	public void LevelFinished()
	{
		EndScreen.transform.position = new Vector3 (0, 0, -6.5f);
		MainCamer.transform.eulerAngles = new Vector3(0, 0, 0);
		Finished = true;
		MoveThese.SetMoving (false);
	}

	public void LevelStarted()
	{
		Started = true;
		MoveThese.SetMoving (Started);
	}	
}