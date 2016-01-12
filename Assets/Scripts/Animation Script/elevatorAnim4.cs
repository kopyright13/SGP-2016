using UnityEngine;
using System.Collections;

public class elevatorAnim4 : MonoBehaviour {
	public GameObject S;
	public GameObject G;
	public GameObject P;
	public GameObject X;
	public int countS = 0;
	public int countG = 0;
	public int countP = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider collider) {
		
		if (collider.name == "S" ) {
			countS = 1;
		} else if (collider.name == "G") {
			countG = 1;
		} else if (collider.name == "P") {
			countP = 1;
		}
	}
	void OnTriggerExit (Collider collider){
		if (collider.name == "S") {
			countS = 0;
		} else if (collider.name == "G") {
			countG = 0;
		} else if (collider.name == "P") {
			countP = 0;
		}
	}
	
	void Update() {
		if (ScoreManager.score == 1 && countS == 1 && countG == 1 && countP == 1) {
			//newCamSwitch.count = 5;
			//Swop.activechar = 5;
			S.transform.Translate (0, -425, 0);
			G.transform.Translate (0, -350, 0);
			P.transform.Translate (0, -350, 0);
			countS = 0;
			countG = 0;
			countP = 0;
			print (countS);
			print (countG);
			print (countP);
			print (ScoreManager.score);
			
		} else if (ScoreManager.score == 2 && countS == 1 && countG == 1 && countP == 1) {
			//newCamSwitch.count = 5;
			//Swop.activechar = 5;
			S.transform.Translate (0, -400, 0);
			G.transform.Translate (0, -400, 0);
			P.transform.Translate (0, -400, 0);
			countS++;
			countG++;
			countP++;
		}
	}
}
