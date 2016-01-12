using UnityEngine;
using System.Collections;

public class buttonDestroy : MonoBehaviour {
	public GameObject[] gameObjects;
	public GameObject[] gameObjects2;
	public GameObject[] gameObjects3;
	void Awake(){
		
		gameObjects = GameObject.FindGameObjectsWithTag ("blockblock");
		gameObjects2 = GameObject.FindGameObjectsWithTag ("block3");
		gameObjects3 = GameObject.FindGameObjectsWithTag ("button3");

	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.name == "P") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				print (i);
			}
			for (var i = 0; i < gameObjects2.Length; i ++) 
			{
				gameObjects2[i].SetActive(false);
				print (i);
			}
			for (var i = 0; i < gameObjects3.Length; i ++) 
			{
				gameObjects3[i].SetActive(false);
				Destroy (this.gameObject);
				print (i);
			}
		}
	}
}