using UnityEngine;
using System.Collections;

public class MoveClouds : MonoBehaviour {

	bool Moving;
	GameObject MovingClouds;

	CharacterController Controller;

	void Start () {
		Moving = false;
		MovingClouds = GameObject.Find("Walls/Clouds");
		Controller = MovingClouds.GetComponent<CharacterController> ();
	}

	public void SetMoving(bool Set)
	{
		Moving = Set;
	}

	void Update()
	{
		if (Moving) 
		{
			Controller.Move(new Vector3 (1,0,0) * Time.deltaTime);
		}
	}
}
