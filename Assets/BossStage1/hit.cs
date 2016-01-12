using UnityEngine;
using System.Collections;

public class hit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "tdps") {
			print ("hit");
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
