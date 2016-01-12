using UnityEngine;
using System.Collections;

public class Loadmain : MonoBehaviour {
	void Update() 
	{
		if (Input.GetKeyDown(KeyCode.Return)) 
		{
			Application.LoadLevel ("StartMenu");
			Time.timeScale = 1;
		}
	}
}