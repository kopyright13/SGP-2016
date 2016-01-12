using UnityEngine;
using System.Collections;

public class mag4A : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter (Collider collider) {
		MagnetScript.counter = 4;
		gMove.grav = 1;

		print ("second button hit");
	}
}
