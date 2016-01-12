using UnityEngine;
using System.Collections;

public class ButtonTriggerFinal : MonoBehaviour {
	public GameObject[] gameObjects;
	void Awake(){
		
		gameObjects = GameObject.FindGameObjectsWithTag ("blockbl");

	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Block" || other.tag == "Player") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(true);
				print (i);
			}
		}
	}
}