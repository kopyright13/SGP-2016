using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dialogue : MonoBehaviour {
	Text text;
	public GameObject[] gameObjects;
	void Start(){
		text = GetComponent<Text> ();
		GameObject[] gameObjects2;
		gameObjects2 = GameObject.FindGameObjectsWithTag ("dialogue");

		gameObjects = GameObject.FindGameObjectsWithTag ("dialogue");
		
		for (var i = 0; i < gameObjects2.Length; i ++) 
		{
			gameObjects2[i].GetComponent<Renderer>().gameObject.SetActive (false);
			//			print (i);
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") 
		{
//			text = GetComponent<Text> (true);
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(true);
				//			print (i);
			}
		}
	}
	void OnTriggerExit(Collider other) 
	{
		if (other.tag == "Player") 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				//			print (i);
			}
		}
	}
}































