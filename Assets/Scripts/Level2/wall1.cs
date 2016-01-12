using UnityEngine;
using System.Collections;

public class wall1 : MonoBehaviour {
	public Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody>();

	}
	// Update is called once per frame
	void Update () {
		if (MagnetScript2.counter == 0) {
						rb.isKinematic = false;		
				} else if (MagnetScript2.counter == 1) {
						rb.isKinematic = true;
				}

	}
}
