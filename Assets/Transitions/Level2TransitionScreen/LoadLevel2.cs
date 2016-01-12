using UnityEngine;
using System.Collections;

public class LoadLevel2 : MonoBehaviour {
	void Update() 
	{
		if (Input.GetKeyDown(KeyCode.Return)) 
		{
			Application.LoadLevel ("Level2Complete");
			Time.timeScale = 1;
		}
	}
}