using UnityEngine;
using System.Collections;

public class buttonTriggerPush : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "blockD" /*|| other.tag == "Player"*/) 
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