using UnityEngine;
using System.Collections;

public class spotLights : MonoBehaviour {
	public GameObject light1;
	public GameObject light2;
	public GameObject light3;
	public GameObject light4;
	int count;


	// Use this for initialization
	void Start () {
		light1.SetActive (false);
		light2.SetActive (false);
		light3.SetActive (false);
		light4.SetActive (false);
		//int count = 0;
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
	if (count == 0) {
			light1.SetActive(true);
			count++;
		}

		else if (count == 1) {
			light2.SetActive(true);
			count++;
		}
		else if (count == 2) {
			light3.SetActive(true);
			count++;
		}
		else if (count == 3) {
			light4.SetActive(true);
			count++;
		}
	}
}
