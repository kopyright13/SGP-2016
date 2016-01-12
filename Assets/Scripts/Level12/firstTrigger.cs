using UnityEngine;
using System.Collections;

public class firstTrigger : MonoBehaviour {
	public GameObject[] gameObjects2;
	void Start(){
		gameObjects2 = GameObject.FindGameObjectsWithTag ("blockblock");
		
		for (var i = 0; i < gameObjects2.Length; i ++) 
		{
			gameObjects2[i].GetComponent<Renderer>().gameObject.SetActive (true);
			print (i);
		}
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") 
		{
			
			for (var i = 0; i < gameObjects2.Length; i ++) 
			{
				gameObjects2[i].SetActive(false);
				print (i);
			}
		}
	}
}