using UnityEngine;
using System.Collections;

public class buttonExit2 : MonoBehaviour {
	public GameObject[] gameObjects;
	public GameObject[]	gameObjects2;
	void Awake(){
		
				gameObjects = GameObject.FindGameObjectsWithTag ("block2");
				gameObjects2 = GameObject.FindGameObjectsWithTag ("button2");
		}

	void OnTriggerExit(Collider other) 
	{
		if (other.tag == "Block" || other.tag == "Player") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				gameObjects2[i].SetActive(false);
			}
		}
	}
}