using UnityEngine;
using System.Collections;

public class wall2 : MonoBehaviour {
	public Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody>();

	}

	void attract(){
		if (MagnetScript3.counter == 1) {
			rb.isKinematic = false;		
		} else if (MagnetScript3.counter == 0) {
			rb.isKinematic = true;
		}
		}
	// Update is called once per frame
	void Update () {


	}
}
