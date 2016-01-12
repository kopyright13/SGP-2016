using UnityEngine;
using System.Collections;

public class buttonTrigger4 : MonoBehaviour {

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") 
		{
			GameObject[] gameObjects;
			gameObjects = GameObject.FindGameObjectsWithTag ("TurretLevel3");
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				Destroy (gameObjects [i]);
			}
		}
		else if (other.tag == "tpds")
		Destroy (this.gameObject);
	}
}