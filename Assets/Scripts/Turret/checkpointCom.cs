using UnityEngine;
using System.Collections;

public class checkpointCom : MonoBehaviour {
	
	// Use this for initialization

	
	void OnTriggerEnter(Collider col){

		//Health hp = gameObject.GetComponent<Health> ();
		//ScoreManager sc = gameObject.GetComponent<ScoreManager> ();
		Health.cur = 7;


		//ScoreManager sc = gameObject.GetComponent<ScoreManager> ();
		//sc.score = 1;
		}

	
}