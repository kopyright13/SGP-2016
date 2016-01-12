using UnityEngine;
using System.Collections;

public class Trigger_SGP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other) {
				if (other.tag == "Player") {
						ScoreManager.score = 2;
			print ("hit");
				}
		}
	// Update is called once per frame
	void Update () {
	
	}
}
