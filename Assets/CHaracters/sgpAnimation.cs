using UnityEngine;
using System.Collections;
public class sgpAnimation : MonoBehaviour {
	public int count;
	// Use this for initialization
	void Awake () {
		GetComponent<Animation>().Play ("IDLE_SGP");
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.A)) {
			print ("move left");
			GetComponent<Animation>().CrossFade ("SGP_MOVE_LEFT");
			print ("blah");
		} else if (Input.GetKeyUp (KeyCode.A)) {
			GetComponent<Animation>().CrossFade ("IDLE_SGP");
			print ("Left Up");
		} else if (Input.GetKeyDown (KeyCode.D)) {
			print ("move right");
			GetComponent<Animation>().CrossFade ("SGP_MOVE");
		} else if (Input.GetKeyUp (KeyCode.D)) {
			GetComponent<Animation>().CrossFade ("IDLE_SGP");
			print ("Right Up");
		} else if (Input.GetKeyUp (KeyCode.W)) {
			GetComponent<Animation>().CrossFade ("JUMP_SGP");
		}
	}


}
