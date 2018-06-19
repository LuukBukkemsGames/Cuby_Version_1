using UnityEngine;
using System.Collections;

public class DiedScreen : MonoBehaviour {

		float ButtonWidth;
		float ButtonHeigth;

		bool Dead;
		
		GameObject DeadScreen;
		GameObject MainCamer;
		
		public MoveClouds MoveThese;
		
		void Start () {
			
			ButtonWidth = Screen.width / 10;
			ButtonHeigth = Screen.height / 10;
			
			DeadScreen = GameObject.FindGameObjectWithTag ("DeadScreen");
			MainCamer = GameObject.FindGameObjectWithTag ("MainCamera");
			
			GUI.color = Color.black;

			Dead = false;
		}
		
		void OnGUI () {
			if (Dead) 
			{
				if(GUI.Button( new Rect( ButtonWidth * 3, (Screen.height / 2 + Screen.height / 4) - 15, ButtonWidth * 2, ButtonHeigth), "Main Menu"))
				{
					Application.LoadLevel("MainMenu");
				}
				if(GUI.Button( new Rect( ButtonWidth * 5, (Screen.height / 2 + Screen.height / 4) - 15, ButtonWidth  * 2, ButtonHeigth), "Retry"))
				{
					Application.LoadLevel(Application.loadedLevel);
				}
			}
		}
				
		public void Died()
		{
			DeadScreen.transform.position = new Vector3 (0, 0, -6.5f);
			MainCamer.transform.eulerAngles = new Vector3(0, 0, 0);
			MoveThese.SetMoving (false);
			Dead = true;
		}
	}