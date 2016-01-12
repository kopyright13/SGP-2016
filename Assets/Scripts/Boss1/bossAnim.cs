using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class bossAnim : MonoBehaviour {
	
	public static int bossHit ;
	public GameObject[] gameObjects;
	public int count = 0;
	// Use this for initialization

	void Update(){
		if (bossHit == 3) {
						Destroy (this.gameObject);
						Application.LoadLevel ("Level2Transition");
				} else if (boss1.bossHit > 0) {
						GetComponent<Animation>().Play ();		
				} else if (boss1.bossHit > 1)
						GetComponent<Animation>().Play ("bossHit2");

	}
}