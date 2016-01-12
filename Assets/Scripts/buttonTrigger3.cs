using UnityEngine;
using System.Collections;

public class buttonTrigger3 : MonoBehaviour {
	public GameObject blueprint;
	int count;
	// Use this for initialization
	void Start () {
		blueprint.SetActive (false);
		blueprint.GetComponent<Renderer> ().gameObject.SetActive (false);
		//int count = 0;
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {

		print ("true");
		if (col.tag == "Player" && count == 0) {
			print ("true");
			blueprint.SetActive (true);
			blueprint.GetComponent<Renderer> ().gameObject.SetActive (true);
			count++;
		}
	}
}
