using UnityEngine;
using System.Collections;

public class magnetMove : MonoBehaviour {
	public GameObject G;
	int count = 0;
	// Use this for initialization
	void OnTriggerEnter (Collider col) {
		if (col.name == "G" && count == 0) {	
						G.transform.Translate (500, 50, 0);
				}
}
}
