////attach to main cam
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;
	//public Texture Start;

	public GUIStyle Start_button;
	public float Start_X;
	public float Start_Y;
	public float size_X;
	public float size_Y;

	public GUIStyle Levels_button;
	public float Levels_X;
	public float Levels_Y;
	public float Levels_size_X;
	public float Levels_size_Y;

	public GUIStyle Quit;
	public float Quit_X;
	public float Quit_Y;
	public float Quit_size_X;
	public float Quit_size_Y;


	void OnGUI(){
	//Displays background Texture
		GUI.DrawTexture (new Rect (0,0, Screen.width, Screen.height), backgroundTexture);

		if (GUI.Button (new Rect(Screen.width * Start_X, Screen.height * Start_Y, Screen.width * size_X, Screen.height * size_Y), "", Start_button)){
			print ("Clicked Play");
			Application.LoadLevel("TutorialTransition");
		}

		if (GUI.Button (new Rect(Screen.width * Levels_X, Screen.height * Levels_Y, Screen.width * Levels_size_X, Screen.height * Levels_size_Y), "",Levels_button)){
			print ("Clicked Levels");
			Application.LoadLevel("TransitionMenu");
		}
		
		if (GUI.Button (new Rect(Screen.width * Quit_X, Screen.height * Quit_Y, Screen.width * Quit_size_X, Screen.height * Quit_size_Y), "", Quit)){
			print ("Clicked Quit");
			Application.Quit();
		}
	}


}