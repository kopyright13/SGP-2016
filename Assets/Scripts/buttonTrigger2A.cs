using UnityEngine;
using System.Collections;

public class buttonTrigger2A : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) 
	{
		if (/*other.tag == "Block" || other.tag == "Player" || */other.tag == "blockD") 
		{
			GameObject[] gameObjects;
			gameObjects = GameObject.FindGameObjectsWithTag ("BlockLevel2");
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				Destroy (gameObjects [i]);
			}
			Destroy (this.gameObject);
		}
	}
}