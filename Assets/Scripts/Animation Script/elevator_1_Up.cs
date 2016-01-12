using UnityEngine;
using System.Collections;

public class elevator_1_Up : MonoBehaviour {
	
	// Use this for initialization
	public GameObject S;
	public GameObject G;
	public GameObject P;
	
	
	void OnTriggerEnter(Collider col){
		if (col.name == "S") {
			S.transform.Translate(-100,+400,0);
		}
		else if(col.name == "G"){
			G.transform.Translate(-100,+430,0);
		}
	}
	
}