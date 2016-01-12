using UnityEngine;
using System.Collections;

public class buttonExit : MonoBehaviour {
	public GameObject[] gameObjects;
	public GameObject[]	gameObjects2;
	public GameObject[]	gameObjects3;
	void Awake(){
		
				gameObjects = GameObject.FindGameObjectsWithTag ("block1");
				gameObjects2 = GameObject.FindGameObjectsWithTag ("button1");
				gameObjects3 = GameObject.FindGameObjectsWithTag ("blockblock");

		}

	void OnTriggerExit(Collider other) 
	{
		if (other.tag == "Block" || other.tag == "Player") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				gameObjects2[i].SetActive(false);
				gameObjects3[i].SetActive(false);
			}
		}
	}
}