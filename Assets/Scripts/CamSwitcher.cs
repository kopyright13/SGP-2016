using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CamSwitcher : MonoBehaviour {
	
	// Private monobehavior members
	int currentCameraIndex = 0;
	List<Camera> characterCameras;
	List<Camera> characterCameras2;
	
	void Start()
	{
		characterCameras = new List<Camera>();
		/// Get the cameras from the scene using Find or as a Parameter
		Camera camera1 = GameObject.Find("Camera1").GetComponent<Camera>();
		characterCameras.Add(camera1);
		Camera camera2 = GameObject.Find("Camera2").GetComponent<Camera>();
		characterCameras.Add(camera2);
		Camera camera3 = GameObject.Find("Camera3").GetComponent<Camera>();
		characterCameras.Add(camera3);


		characterCameras2 = new List<Camera>();
		Camera camera4 = GameObject.Find("Camera4").GetComponent<Camera>();
		characterCameras2.Add(camera4);
	}
	
	
	void Update()
	{
		if(Input.GetKeyUp(KeyCode.UpArrow))
		{
			// Increment the camera index to the next camera in the list
			currentCameraIndex++;
			print("the count is " + currentCameraIndex);
			if( characterCameras.Count == currentCameraIndex || currentCameraIndex == 6)
			{
				currentCameraIndex = 0;
			}
			// loop over the camera list, disabling all but the chosen index
			foreach(Camera camera in characterCameras)
			{
				if(camera == characterCameras[currentCameraIndex])
				{
					camera.enabled = true;
				}
				else
				{
					camera.enabled = false;
				}
			}

		}
		if(Input.GetKeyUp(KeyCode.DownArrow))
		{
			characterCameras[0].tag = "Untagged";
			characterCameras2[0].tag = "MainCamera";
			currentCameraIndex = 4;
			print("the count is " + currentCameraIndex);
			currentCameraIndex++;
			foreach(Camera camera in characterCameras2)
			{
				if(camera == characterCameras2[0])
				{
					camera.enabled = true;
				}
				else
				{
					camera.enabled = false;
				}
			}
		}
	}
}