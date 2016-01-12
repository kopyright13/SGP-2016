using UnityEngine;
using System.Collections;

public class moveWall2 : MonoBehaviour {
	int counter = 0;
	public GameObject[] gameObjects;
	void Start(){
		//GameObject[] gameObjects2;
		//gameObjects2 = GameObject.FindGameObjectsWithTag ("block1");
		
		gameObjects = GameObject.FindGameObjectsWithTag ("wall");
		
		for (var i = 0; i < gameObjects.Length; i ++) 
		{
			gameObjects[i].GetComponent<Renderer>().gameObject.SetActive (true);
			print (i);
		}
	}
	// Update is called once per frame
	void OnTriggerEnter (Collider collider) {
		if (counter == 0) {
				counter = 1;
						MagnetScript3.counter = 2;
			print ("work");
				}
		if (collider.tag == "Block") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				print (i);
			}
		}
	}

	void OnTriggerExit (Collider collider){
		if (counter == 1) {
			counter = 0;
			MagnetScript3.counter = 1;
			print ("off");
		}
	}
}
