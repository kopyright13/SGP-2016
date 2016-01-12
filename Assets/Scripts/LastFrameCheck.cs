using UnityEngine;
using System.Collections;

public class LastFrameCheck : MonoBehaviour {
	public static float Frame;
	// Use this for initialization
	void Start () {
	
	}
	void PrintFloat (float theValue) {
		Debug.Log ("PrintFloat is called with a value of " + theValue);
		if (theValue == 1) {
			print ("I think it works hmmm");
			Frame = theValue;
			//theValue = Elevator_trigger.floor1;
			//ScoreManager.score = 1;  Elevator_trigger.countS = 1;  Elevator_trigger.countG = 1;
			//Application.LoadLevel ("tutorialLvl");
		
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
