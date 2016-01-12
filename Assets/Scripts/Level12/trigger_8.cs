using UnityEngine;
using System.Collections;

public class trigger_8 : MonoBehaviour {
	public GameObject[] gameObjects;
	public GameObject[] gameObjects2;
	void Start(){
	gameObjects2 = GameObject.FindGameObjectsWithTag ("dialogue7");
	
	gameObjects = GameObject.FindGameObjectsWithTag ("dialogue7");
	
	for (var i = 0; i < gameObjects2.Length; i ++) 
	{
		gameObjects2[i].GetComponent<Renderer>().gameObject.SetActive (false);
		//			print (i);
	}
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.name == "S" || other.name == "G" ) 
		{
			Swop3.found = 2;
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(true);
				//			print (i);
			}
		}
	}

	void OnTriggerExit(Collider other) 
	{
		if (other.name == "S" || other.name == "G" ) 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				//			print (i);
			}
		}
	}
}