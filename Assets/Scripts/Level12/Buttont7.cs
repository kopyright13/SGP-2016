using UnityEngine;
using System.Collections;

public class Buttont7 : MonoBehaviour {
	public GameObject[] gameObjects;
	void Start(){
		GameObject[] gameObjects2;
		gameObjects2 = GameObject.FindGameObjectsWithTag ("laser");
		
		gameObjects = GameObject.FindGameObjectsWithTag ("laser");
		
		for (var i = 0; i < gameObjects2.Length; i ++) 
		{
			gameObjects2[i].GetComponent<Renderer>().gameObject.SetActive (true);
			print (i);
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Block") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				print (i);
			}
		}
	}
}