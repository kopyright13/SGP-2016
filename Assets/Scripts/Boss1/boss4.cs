using UnityEngine;
using System.Collections;

public class boss4 : MonoBehaviour {
	public GameObject[] gameObjects;
	public int count;
	void Awake (){
		gameObjects = GameObject.FindGameObjectsWithTag ("T4L2");
		
		for (var i = 0; i < gameObjects.Length; i ++) 
		{
			gameObjects[i].GetComponent<Renderer>().gameObject.SetActive (false);
		}
	
	}
	void OnTriggerEnter (Collider collide) {
		count = 1;
		if (collide.tag == "Player") {
								boss1.bossHit += 1;
						for (var i = 0; i < gameObjects.Length; i ++) {
								gameObjects [i].SetActive (true);
						}
						Destroy (this.gameObject);
				}
	}
}
