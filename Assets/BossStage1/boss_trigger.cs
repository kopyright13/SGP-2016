using UnityEngine;
using System.Collections;

public class boss_trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void PrintFloat (float theValue) {
				Debug.Log ("PrintFloat is called with a value of " + theValue);
				if (theValue == 1) {
						Application.LoadLevel("Level2Transition");
				}
	}

	
	// Update is called once per frame
	void Update () {
		if (boss1.bossHit == 1) {
						GetComponent<Animator> ().SetBool ("hit_1", true);
			print("hurt 1");
		}
		else if (boss1.bossHit == 2) {
			GetComponent<Animator> ().SetBool ("hit_2", true);
			print("hurt 2");
		}
		else if (boss1.bossHit == 3) {
			GetComponent<Animator> ().SetBool ("hit_3", true);
			print("hurt 3");
		}
	}

}
