using UnityEngine;
using System.Collections;

public class LoadTutorial : MonoBehaviour {
	void Update() 
	{
		if (Input.GetKeyDown(KeyCode.Return)) 
		{
			Application.LoadLevel ("tutorialLvl");
		}
	}
}