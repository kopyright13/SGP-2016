using UnityEngine;
using System.Collections;

public class checkpoint5 : MonoBehaviour {
	
	// Use this for initialization

	
	void OnTriggerEnter(Collider col){

		//Health hp = gameObject.GetComponent<Health> ();
		//ScoreManager sc = gameObject.GetComponent<ScoreManager> ();
		ScoreManager.score = 1;
		Health.cur = 3;


		//ScoreManager sc = gameObject.GetComponent<ScoreManager> ();
		//sc.score = 1;
		}

	
}