﻿using UnityEngine;
using System.Collections;

public class Buttont2 : MonoBehaviour {
	public GameObject[] gameObjects;
	void Start(){
		GameObject[] gameObjects2;
		gameObjects2 = GameObject.FindGameObjectsWithTag ("block11A");

		gameObjects = GameObject.FindGameObjectsWithTag ("block11A");
		
		for (var i = 0; i < gameObjects2.Length; i ++) 
		{
			gameObjects2[i].GetComponent<Renderer>().gameObject.SetActive (true);
//			print (i);
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "blockD" /*|| other.tag == "Player"*/) 
		{
			
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive(false);
				//print (i);
			}
		}
	}
}