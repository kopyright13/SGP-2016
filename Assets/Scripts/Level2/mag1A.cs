using UnityEngine;
using System.Collections;

public class mag1A : MonoBehaviour {
	int counter = 0;
	public GameObject[] gameObjects;

	void Start(){
		gameObjects = GameObject.FindGameObjectsWithTag ("floortrigger2");
		
		for (var i = 0; i < gameObjects.Length; i ++) 
		{
			gameObjects[i].GetComponent<Renderer>().gameObject.SetActive (false);
			print (i);
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		// Update is called once per frame
		print ("first button hit");
		if (other.tag == "Player") 
		{
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(true);
				print (i);
			}
		}
	}

}
