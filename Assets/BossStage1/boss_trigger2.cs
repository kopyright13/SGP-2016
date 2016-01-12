using UnityEngine;
using System.Collections;

public class boss_trigger2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void PrintFloat (float theValue) {
				Debug.Log ("PrintFloat is called with a value of " + theValue);
				if (theValue == 1) {
						Application.LoadLevel("WinTransition");
				}
	}


	// Update is called once per frame
	void Update () {
		if (b1.counter == 1) {
						GetComponent<Animator> ().SetBool ("hit_1", true);
			print("hurt 1");
		}
		else if (b1.counter  == 2) {
			GetComponent<Animator> ().SetBool ("hit_2", true);
			print("hurt 2");
		}
		else if (b1.counter  == 3) {
			GetComponent<Animator> ().SetBool ("hit_3", true);
			print("hurt 3");
		}
	}

}
