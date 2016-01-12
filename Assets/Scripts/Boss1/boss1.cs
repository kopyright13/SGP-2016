using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class boss1 : MonoBehaviour {
	
	public static int bossHit ;
	public GameObject[] gameObjects;
	public int count = 0;
	// Use this for initialization
	void Awake () {
		bossHit = 0;
		DontDestroyOnLoad(this);
		gameObjects = GameObject.FindGameObjectsWithTag ("T1L2");
				for (var i = 0; i < gameObjects.Length; i ++) 
		{
			gameObjects[i].GetComponent<Renderer>().gameObject.SetActive (false);
		}
	

	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider collide) {

			bossHit += 1;
			print (bossHit);
			for (var i = 0; i < gameObjects.Length; i ++) 
			{
				gameObjects[i].SetActive (true);
			}
			}

	void Update(){
		print("bossHit is " +  bossHit);
		//if (bossHit == 3) {
		//	Destroy(this.gameObject);
			//Application.LoadLevel("Level2Transition");
	}
}