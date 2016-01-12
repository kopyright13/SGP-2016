using UnityEngine;
using System.Collections;

public class mag1 : MonoBehaviour {
	int counter = 0;
	public GameObject[] gameObjects;

	void Start(){
		gameObjects = GameObject.FindGameObjectsWithTag ("floortrigger");
		
		for (var i = 0; i < gameObjects.Length; i ++) 
		{
			gameObjects[i].GetComponent<Renderer>().gameObject.SetActive (false);
			print (i);
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		// Update is called once per frame
		counter = 1;
		MagnetScript.counter = 1;
		print ("IT TOUCHED ME");
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
