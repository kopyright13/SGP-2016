using UnityEngine;
using System.Collections;

public class buttonTriggerLevel1T_Right : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Block" || other.tag == "Player") 
		{
			GameObject[] gameObjects;
			gameObjects = GameObject.FindGameObjectsWithTag ("TurretsLevel1R");
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				Destroy (gameObjects [i]);
			}
			Destroy (this.gameObject);
		}
	}
}