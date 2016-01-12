using UnityEngine;
using System.Collections;
public class BluePrintPICKUP : MonoBehaviour {
	public int scoreValue = 1;
	int count = 0;
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player" && count == 0) {
			count++;
			Destroy (this.gameObject);
			ScoreManager.score+= scoreValue;
		} else {
			return;
		}
	}
}