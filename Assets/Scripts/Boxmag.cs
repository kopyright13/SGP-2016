using UnityEngine;
using System.Collections;

public class Boxmag : MonoBehaviour {

	public GameObject[] gameObjects;
	void Start(){

		gameObjects = GameObject.FindGameObjectsWithTag ("Block");
		for (var i = 0; i < gameObjects.Length; i ++) {
						gameObjects [i].GetComponent<Renderer> ().gameObject.SetActive (true);
				}
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Block") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				print (i);
			}
		}
	}
}
