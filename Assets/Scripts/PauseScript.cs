using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {

	public bool CanPause;
	public GameObject PauseMenu;

	public float guiPlacementX;
	public float guiPlacementY;
	public float guiPlacementX1;
	public float guiPlacementY1;
	public float guiPlacementX2;
	public float guiPlacementY2;

	private Texture backgroundTexture;
	
	void Start () 
	{
		CanPause = true;
	}
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.LeftShift)) 
		{
			if(CanPause)
			{
				Debug.Log("Game Paused");
				Time.timeScale = 0;
				CanPause = false;
				PauseMenu.GetComponent<Renderer>().gameObject.SetActive (true);
			}
			else
			{
				Time.timeScale = 1;
				CanPause = true;
				PauseMenu.GetComponent<Renderer>().gameObject.SetActive (false);
			}
		}
	}

	void OnGUI()
	{

		//Displays background Texture
		if (CanPause == false) 
		{
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

			if (GUI.Button (new Rect (Screen.width * guiPlacementX, Screen.height * guiPlacementY, Screen.width * .25f, Screen.height * .1f), "Restart Level")) 
			{
				print ("Clicked Restart");
				Application.LoadLevel(Application.loadedLevelName);
				Time.timeScale = 1;
			}
			if (GUI.Button (new Rect (Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .25f, Screen.height * .25f),
			                "Controls:\nAction Key = Space\nMove Left = W/Left Arrow\nMove Right = D/Right Arrow" +
			                "\nSwitch Characters = E\nPause = Left Shift\nShot Aiming = Mouse")) 
			{
				print ("Clicked Controls");
			}
			if (GUI.Button (new Rect (Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .25f, Screen.height * .1f), "Quit to Main Menu")) 
			{
				print ("Clicked Quit to Main Menu");
				Application.LoadLevel("StartMenu");
			}
		}
	}
}