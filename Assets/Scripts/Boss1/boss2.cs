using UnityEngine;
using System.Collections;

public class boss2 : MonoBehaviour {
	public GameObject[] gameObjects;
	public int count = 0;
	void Awake (){
		gameObjects = GameObject.FindGameObjectsWithTag ("T2L2");
		
		for (var i = 0; i < gameObjects.Length; i ++) 
		{
			gameObjects[i].GetComponent<Renderer>().gameObject.SetActive (false);
		}
	
	}
	void OnTriggerEnter (Collider collide) {

		boss1.bossHit += 1;

		for (var i = 0; i < gameObjects.Length; i ++) 
		{
			gameObjects[i].SetActive (true);
		}
		Destroy(this.gameObject);
	}
}
