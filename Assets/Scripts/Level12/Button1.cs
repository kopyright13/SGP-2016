using UnityEngine;
using System.Collections;

public class Button1 : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Block" || other.tag == "Player") 
		{
			GameObject[] gameObjects;
			gameObjects = GameObject.FindGameObjectsWithTag ("T1L2");
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				Destroy (gameObjects [i]);
			}
			Destroy (this.gameObject);
		}
	}
}