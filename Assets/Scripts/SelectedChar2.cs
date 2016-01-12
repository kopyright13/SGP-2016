using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelectedChar2 : MonoBehaviour {
	
	// Private monobehavior members
	public GameObject SOn;
	public GameObject GOn;
	public GameObject POn;
	public GameObject SOff;
	public GameObject GOff;
	public GameObject POff;
	public int count;

	
	void Start()
	{
		//SOn.SetActive (true);
		//GOn.SetActive (false);
		//POn.SetActive (false);
		//SOff.SetActive (false);
		//GOff.SetActive (true);
		//POff.SetActive (true);
		count = 1;
		
	}
	
	
	void Update()
	{
		print ("count in selected" + count);
		if (Swop.activechar == 5) {
						SOn.SetActive (true);
						GOn.SetActive (false);
						POn.SetActive (false);
						SOff.SetActive (false);
						GOff.SetActive (true);
						POff.SetActive (true);
				count = 1;
						}

		if (Swop3.found == 0) {
						if (count == 1) {
								SOn.SetActive (true);
								GOn.SetActive (false);
								POn.SetActive (false);
								SOff.SetActive (false);
								GOff.SetActive (true);
								POff.SetActive (true);
						} 
				} else if (Swop3.found == 1) {

						if (Input.GetKeyDown (KeyCode.E)) {
								count++;
								if (count == 1) {
										SOn.SetActive (true);
										GOn.SetActive (false);
										POn.SetActive (false);
										SOff.SetActive (false);
										GOff.SetActive (true);
										POff.SetActive (true);
								} else if (count == 2) {
										SOn.SetActive (false);
										GOn.SetActive (true);
										POn.SetActive (false);
										SOff.SetActive (true);
										GOff.SetActive (false);
										POff.SetActive (true);
										count = 0;
								} 
						}
				} else if (Swop3.found == 2) {
						print ("this is happening");
			if (Input.GetKeyDown (KeyCode.E)) {
						count++;
								if (count == 1) 
								{
										SOn.SetActive (true);
										GOn.SetActive (false);
										POn.SetActive (false);
										SOff.SetActive (false);
										GOff.SetActive (true);
										POff.SetActive (true);
								} 
								else if (count == 2) 
								{
										SOn.SetActive (false);
										GOn.SetActive (true);
										POn.SetActive (false);
										SOff.SetActive (true);
										GOff.SetActive (false);
										POff.SetActive (true);
								} else if (count == 3) {
										SOn.SetActive (false);
										POn.SetActive (true);
										GOn.SetActive (false);
										SOff.SetActive (true);
										POff.SetActive (false);
										GOff.SetActive (true);
										count = 0;
								} 
						}
				}
			
			else if (Input.GetKeyUp (KeyCode.DownArrow) && ScoreManager.score == 3) {
								SOn.SetActive (true);
								GOn.SetActive (true);
								POn.SetActive (true);
								SOff.SetActive (false);
								GOff.SetActive (false);
								POff.SetActive (false);

						}
				}
		
}