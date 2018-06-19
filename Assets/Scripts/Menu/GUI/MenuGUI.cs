using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour {
	float ButtonWidth;
	float ButtonHeigth;

	void Start () {
		ButtonWidth = Screen.width / 10;
		ButtonHeigth = ButtonWidth / 4;
	
	}

	void OnGUI () {
		if(GUI.Button( new Rect( ButtonWidth * 4 - 10,  ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 1"))
		{
			Application.LoadLevel("Level1");
		}
		if(GUI.Button( new Rect(ButtonWidth * 5 , ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 2"))
		{
			Application.LoadLevel("Level2");
		}
		if(GUI.Button( new Rect(ButtonWidth * 6 + 10, ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 3"))
		{
			Application.LoadLevel("Level3");
		}
		if(GUI.Button( new Rect( ButtonWidth * 7 + 20, ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 4"))
		{
			Application.LoadLevel("Level4");
		}


		if(GUI.Button( new Rect( ButtonWidth * 4 - 10,  3 * ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 5"))
		{
			Application.LoadLevel("Level5");
		}
		if(GUI.Button( new Rect(ButtonWidth * 5 , 3 * ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 6"))
		{
			Application.LoadLevel("Level6");
		}
		if(GUI.Button( new Rect(ButtonWidth * 6 + 10, 3 * ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 7"))
		{
			Application.LoadLevel("Level7");
		}
		if(GUI.Button( new Rect( ButtonWidth * 7 + 20, 3 * ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 8"))
		{
			Application.LoadLevel("Level8");
		}


		if(GUI.Button( new Rect( ButtonWidth * 4 - 10,  5 * ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 9"))
		{
			Application.LoadLevel("Level9");
		}
		if(GUI.Button( new Rect(ButtonWidth * 5 , 5 * ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 10"))
		{
			Application.LoadLevel("Level10");
		}
		if(GUI.Button( new Rect(ButtonWidth * 6 + 10, 5 * ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 11"))
		{
			Application.LoadLevel("Level11");
		}
		if(GUI.Button( new Rect( ButtonWidth * 7 + 20, 5 * ButtonHeigth, ButtonWidth, ButtonHeigth), "Level 12"))
		{
			Application.LoadLevel("Level12");
		}


		if(GUI.Button(new Rect(ButtonWidth * 1,Screen.height - (2 * ButtonHeigth ), ButtonWidth + 20, ButtonHeigth), "Exit Game"))
		{
			Application.Quit();
		}
		 
		if(GUI.Button(new Rect(ButtonWidth * 3,Screen.height - (2 * ButtonHeigth), ButtonWidth + 20, ButtonHeigth), "Controls"))
		{
			Application.LoadLevel("Controls");
		}

		if(GUI.Button(new Rect(ButtonWidth * 5,Screen.height - (2 * ButtonHeigth), ButtonWidth + 20, ButtonHeigth), "Next Page"))
		{
			Debug.Log("U wot m9");
		}

	}
}
