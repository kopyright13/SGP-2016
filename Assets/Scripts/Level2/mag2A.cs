using UnityEngine;
using System.Collections;

public class mag2A : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter (Collider collider) {
		MagnetScript.counter = 5;
		print ("third button hit");
	}
}
