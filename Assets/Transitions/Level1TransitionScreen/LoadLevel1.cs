using UnityEngine;
using System.Collections;

public class LoadLevel1 : MonoBehaviour {
	void Update() 
	{
		if (Input.GetKeyDown(KeyCode.Return)) 
		{
			Application.LoadLevel ("Level1");
			Time.timeScale = 1;
		}
	}
}