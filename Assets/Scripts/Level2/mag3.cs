using UnityEngine;
using System.Collections;

public class mag3 : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter (Collider collider) {
		MagnetScript.counter = 0;
		gMove.grav = 0;
		print ("IT TOUCHED ME FOR ONCE");
	}
}
