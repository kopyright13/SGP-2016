using UnityEngine;
using System.Collections;

public class mag2 : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter (Collider collider) {
		MagnetScript.counter = 3;
		print ("IT TOUCHED ME 3 TIMES");
	}
}
