using UnityEngine;
using System.Collections;

public class TurretDestroy1 : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Block" || other.tag == "Player") 
		{
			GameObject[] gameObjects;
			gameObjects = GameObject.FindGameObjectsWithTag ("T2L3");
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				Destroy (gameObjects [i]);
			}
			Destroy (this.gameObject);
		}
	}
}