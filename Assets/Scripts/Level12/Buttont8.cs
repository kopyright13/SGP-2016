using UnityEngine;
using System.Collections;

public class Buttont8 : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) 
	{
		//GameObject[] gameObjects;
		if (other.tag == "Block") 
		{
			GameObject[] gameObjects;
			//GameObject[] gameObjects ("TurrentsLevel1D");
			
			//for (var i = 0; i < gameObjects.Length; i ++) 
			{
			//	Destroy (gameObjects [i]);
			}
			//Destroy (this.gameObject);
		}
	}
}