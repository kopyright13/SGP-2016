using UnityEngine;
using System.Collections;

public class mag4 : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter (Collider collider) {
		MagnetScript.counter = 2;
		gMove.grav = 1;

		print ("IT TOUCHED ME HELP");
	}
}
