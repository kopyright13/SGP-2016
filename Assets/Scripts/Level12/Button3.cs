using UnityEngine;
using System.Collections;

public class Button3 : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Block" || other.tag == "Player") 
		{
			GameObject[] gameObjects;
			gameObjects = GameObject.FindGameObjectsWithTag ("T3L2");
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				Destroy (gameObjects [i]);
			}
			Destroy (this.gameObject);
		}
	}
}