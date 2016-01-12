using UnityEngine;
using System.Collections;

public class Button8 : MonoBehaviour {
	public GameObject[] gameObjects;
	void Awake(){
		GameObject[] gameObjects2;
		gameObjects2 = GameObject.FindGameObjectsWithTag ("block3");

		gameObjects = GameObject.FindGameObjectsWithTag ("block3");
		
		for (var i = 0; i < gameObjects2.Length; i ++) 
		{
			gameObjects2[i].GetComponent<Renderer>().gameObject.SetActive (false);
			print (i);
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Block" || other.tag == "Player") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(true);
				print (i);
			}
		}
	}
}