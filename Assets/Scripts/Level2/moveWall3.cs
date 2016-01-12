using UnityEngine;
using System.Collections;

public class moveWall3 : MonoBehaviour {
	int counter = 0;
	// Update is called once per frame
	void OnTriggerEnter (Collider collider) {
		if (counter == 0) {
				counter = 1;
						MagnetScript4.counter = 1;
			print ("work");
				}
	}
	void OnTriggerExit (Collider collider){
		if (counter == 1) {
			counter = 0;
			MagnetScript4.counter = 0;
			print ("off");
		}
	}
}
