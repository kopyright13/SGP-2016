using UnityEngine;
using System.Collections;
public class BluePrint : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player" || other.tag == "Block" || other.tag == "tdps" || other.tag == "Wall" || other.tag == "blockD") {
			return;
		} else {
			Destroy (this.gameObject);
		}
	}
}