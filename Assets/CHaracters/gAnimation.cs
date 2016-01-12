using UnityEngine;
using System.Collections;
public class gAnimation : MonoBehaviour {
	public int count;
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim.SetBool("idle", true);
	}

	void OnTriggerEnter(Collider collision){
						count = 1;
				
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.A)) {
			anim.SetBool("idle", false);
			anim.SetBool("moveL", true);
			if(count == 1){
				anim.SetBool("pushL", true);
			}
		} else if (Input.GetKeyUp (KeyCode.A)) {
			anim.SetBool("moveL", false);
			anim.SetBool("pushL", false);
		} else if (Input.GetKeyDown (KeyCode.D)) {
			anim.SetBool("idle", true);
			anim.SetBool("moveR", true);
			if(count == 1){
				anim.SetBool("pushR", true);
			}
		} else if (Input.GetKeyUp (KeyCode.D)) {
			anim.SetBool("moveR", false);
			anim.SetBool("pushR", false);
		}
	}
}
