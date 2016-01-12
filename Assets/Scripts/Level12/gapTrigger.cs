using UnityEngine;
using System.Collections;

public class gapTrigger : MonoBehaviour {
	public GameObject[] gameObjects;
	void Start(){
		gameObjects = GameObject.FindGameObjectsWithTag ("gap");
		
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
	void OnTriggerExit(Collider other){
		if (other.tag == "Block" || other.tag == "Player") 
		{
			print ("i");
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				print (i);
			}
		}
	}
}