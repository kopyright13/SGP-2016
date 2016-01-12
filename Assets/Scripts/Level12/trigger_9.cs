using UnityEngine;
using System.Collections;

public class trigger_9 : MonoBehaviour {
	public GameObject[] gameObjects;
	public GameObject[] gameObjects2;
	void Start(){
	gameObjects2 = GameObject.FindGameObjectsWithTag ("dialogue8");
	
	gameObjects = GameObject.FindGameObjectsWithTag ("dialogue8");
	
	for (var i = 0; i < gameObjects2.Length; i ++) 
	{
		gameObjects2[i].GetComponent<Renderer>().gameObject.SetActive (false);
		//			print (i);
	}
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") 
		{
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(true);
				//			print (i);
			}
		}
	}

	void OnTriggerExit(Collider other) 
	{
		if (other.tag == "Player") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				//			print (i);
			}
		}
	}
}