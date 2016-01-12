////attach to main cam
using UnityEngine;
using System.Collections;

public class LevelMenu : MonoBehaviour {

	public Texture backgroundTexture;
	//public Texture Start;

	public GUIStyle Tutorial_button;
	public float Tutorial_X;
	public float Tutorial_Y;
	public float Tutorial_size_X;
	public float Tutorial_size_Y;

	public GUIStyle Level1_button;
	public float Level1_X;
	public float Level1_Y;
	public float Level1_size_X;
	public float Level1_size_Y;

	public GUIStyle Level2_button;
	public float Level2_X;
	public float Level2_Y;
	public float Level2_size_X;
	public float Level2_size_Y;


	void OnGUI(){
	//Displays background Texture
		GUI.DrawTexture (new Rect (0,0, Screen.width, Screen.height), backgroundTexture);

		if (GUI.Button (new Rect(Screen.width * Tutorial_X, Screen.height * Tutorial_Y, Screen.width * Tutorial_size_X, Screen.height * Tutorial_size_Y), "", Tutorial_button)){
			print ("Clicked Play");
			Application.LoadLevel("TutorialTransition");
		}

		if (GUI.Button (new Rect(Screen.width * Level1_X, Screen.height * Level1_Y, Screen.width * Level1_size_X, Screen.height * Level1_size_Y), "",Level1_button)){
			print ("Clicked Levels");
			Application.LoadLevel("Level1Transition");
		}
		
		if (GUI.Button (new Rect(Screen.width * Level2_X, Screen.height * Level2_Y, Screen.width * Level2_size_X, Screen.height * Level2_size_Y), "", Level2_button)){
			print ("Clicked Quit");
			Application.LoadLevel("Level2Transition");
		}
	}


}