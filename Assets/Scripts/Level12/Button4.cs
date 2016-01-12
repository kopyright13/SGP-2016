using UnityEngine;
using System.Collections;

public class Button4 : MonoBehaviour {
	public GameObject[] gameObjects;
	void Start(){
		//GameObject[] gameObjects2;
		//gameObjects2 = GameObject.FindGameObjectsWithTag ("block1");

	   gameObjects = GameObject.FindGameObjectsWithTag ("block1");
		
		for (var i = 0; i < gameObjects.Length; i ++) 
		{
			gameObjects[i].GetComponent<Renderer>().gameObject.SetActive (false);
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