using UnityEngine;
using System.Collections;

public class checkpointLower : MonoBehaviour {
	
	// Use this for initialization

	
	void OnTriggerEnter(Collider col){

		//Health hp = gameObject.GetComponent<Health> ();
		///ScoreManager sc = gameObject.GetComponent<ScoreManager> ();
		ScoreManager.score = 2;
		Health.cur = 5;


		//ScoreManager sc = gameObject.GetComponent<ScoreManager> ();
		//sc.score = 1;
		}

	
}