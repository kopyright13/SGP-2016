using UnityEngine;
using System.Collections;

public class PHys : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.name == "G") {
			Physics.gravity = new Vector3(0, 0, 0);
				}
	}
}
