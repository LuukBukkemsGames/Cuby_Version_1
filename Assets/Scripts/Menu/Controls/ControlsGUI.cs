using UnityEngine;
using System.Collections;

public class ControlsGUI : MonoBehaviour {

	float ButtonWidth;
	float ButtonHeigth;
	
	void Start () {
		ButtonWidth = Screen.width / 10;
		ButtonHeigth = ButtonWidth / 4;
		
	}
	
	void OnGUI () {
		if(GUI.Button( new Rect( ButtonWidth ,  Screen.height - ( 5 * ButtonHeigth), ButtonWidth * 4, ButtonHeigth * 2), "Back"))
		{
			Application.LoadLevel("MainMenu");
		}
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.LoadLevel("MainMenu");		
		}
	}
}
