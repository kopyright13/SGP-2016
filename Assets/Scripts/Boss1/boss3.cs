using UnityEngine;
using System.Collections;

public class boss3 : MonoBehaviour {
	public GameObject[] gameObjects;
	void Start (){
				gameObjects = GameObject.FindGameObjectsWithTag ("T4L2");
		print ("hey");
				for (var i = 0; i < gameObjects.Length; i ++) {
						gameObjects[i].GetComponent<Renderer> ().gameObject.SetActive (false);
				}
		}
	void OnTriggerEnter (Collider collide) {
		boss1.bossHit += 1;
		bossAnim.bossHit += 1;
		for (var i = 0; i < gameObjects.Length; i ++) 
		{
			gameObjects[i].SetActive (true);
		}
		Destroy(this.gameObject);
	}
}
