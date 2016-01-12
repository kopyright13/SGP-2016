using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class newCamSwitch4 : MonoBehaviour {
	
	// Private monobehavior members
	public GameObject cam1;
	public GameObject cam2;
	public GameObject cam3;
	public GameObject cam4;
	public GameObject cam5;
	public static int count;
	public int scoreValue;
	public static float check;
	
	void Start()
	{
		cam1.SetActive (true);
		cam2.SetActive (false);
		cam3.SetActive (false);
		cam4.SetActive (false);
		cam5.SetActive (false);
		count = 1;


	}
	
	
	void Update()
	{
		if (count == 5) {
			print ("Camera 5 is active");
			cam1.SetActive (false);
			cam2.SetActive (false);
			cam3.SetActive (false);
			cam5.SetActive (true);
			if (Elevator_trigger.track == 4 || Input.GetKeyUp (KeyCode.Return)) {
				count = 1;
				print("camera swap");
				cam1.SetActive (true);
				cam2.SetActive (false);
				cam3.SetActive (false);
				cam5.SetActive (false);
			}
		}

		if (Input.GetKeyUp (KeyCode.E) && Swop4.roar == 0) {
			// Increment the camera index to the next camera in the list
			count++;
			if (count == 1) {
				cam1.SetActive (true);
				cam2.SetActive (false);
				cam3.SetActive (false);
			} else if (count == 2) {
				cam1.SetActive (false);
				cam2.SetActive (false);
				cam3.SetActive (true);
			} else if (count == 3) {
				cam1.SetActive (false);
				cam2.SetActive (true);
				cam3.SetActive (false);
				count = 0;
			}
		}
		if(Input.GetKeyUp(KeyCode.DownArrow) && ScoreManager.score == 2 )
		{
			count = 4;
			if(count == 4){
				cam1.SetActive (false);
				cam2.SetActive (false);
				cam3.SetActive (false);
				cam4.SetActive (true);
				cam1.tag = "Untagged";
				cam4.tag = "MainCamera";
			}
		}
	}
}