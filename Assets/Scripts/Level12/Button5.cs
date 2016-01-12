using UnityEngine;
using System.Collections;

public class Button5 : MonoBehaviour {
	public GameObject[] gameObjects;
	public GameObject[] gameObjects2;
	void Awake(){
		
		gameObjects = GameObject.FindGameObjectsWithTag ("blockblock");
		gameObjects2 = GameObject.FindGameObjectsWithTag ("block1");

	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(true);
				print (i);
			}
		}
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			for (var i = 0; i < gameObjects.Length; i ++) {
				gameObjects [i].SetActive (false);
				gameObjects2 [i].SetActive (false);
				}
		}
	}
}