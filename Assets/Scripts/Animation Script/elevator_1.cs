using UnityEngine;
using System.Collections;

public class elevator_1 : MonoBehaviour {

	// Use this for initialization

	void OnTriggerEnter(Collider col){
				if (col.name == "SPG") {
						GetComponent<Animator> ().SetBool ("touched", true);
				}
		}
	void OnTriggerExit(Collider col){
			
				GetComponent<Animator> ().SetBool ("touched", false);
		}
	
}