using UnityEngine;
using System.Collections;

public class elevator_2_Up: MonoBehaviour {
	
	// Use this for initialization
	public GameObject S;
	public GameObject G;
	public GameObject P;
	
	
	void OnTriggerEnter(Collider col){
		if (col.name == "S") {
			S.transform.Translate (+30, +430, 0);
		} else if (col.name == "G") {
			G.transform.Translate (+30, +430, 0);
		} else if (col.name == "P") {
			P.transform.Translate (+30, +430, 0);
		}
	}	
}