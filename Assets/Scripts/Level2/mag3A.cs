using UnityEngine;
using System.Collections;

public class mag3A : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter (Collider collider) {
		MagnetScript.counter = 0;
		gMove.grav = 0;
		print ("last button hit");
	}
}
